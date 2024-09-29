using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
public class AddPictureMode : MonoBehaviour
{
    public ImageInfo imageInfo;
    [SerializeField] float defaultScale = 0.5f;
    [SerializeField] GameObject placedPrefab;
    [SerializeField] GameObject addUICanvas;
    List<ARRaycastHit> hits = new List<ARRaycastHit>();
    void OnEnable()
    {
        UIController.ShowUI("AddPicture");
    }
    public void OnPlaceObject(InputValue value)
    {
        if (addUICanvas.active)
        {
            Vector2 touchPosition = value.Get<Vector2>();
            PlaceObject(touchPosition);
        }

    }
    void PlaceObject(Vector2 touchPosition)
    {
        ARRaycastManager raycaster = GetComponent<ARRaycastManager>();
        if (raycaster.Raycast(touchPosition, hits,
         TrackableType.PlaneWithinPolygon))
        {
            Pose hitPose = hits[0].pose;
            Vector3 normal = -hitPose.up;
            Quaternion rotation = Quaternion.LookRotation(normal, Vector3.up);
            GameObject spawned = Instantiate(placedPrefab, hitPose.position,
            rotation);
            FramedPhoto picture = spawned.GetComponent<FramedPhoto>();
            picture.SetImage(imageInfo);
            // Find the Image object in the prefab
            //Transform imageTransform = spawned.transform.Find("FramedPhoto/AspectScaler/Image");

            //Renderer imageRenderer = imageTransform.GetComponent<Renderer>();
            //imageRenderer.material.SetTexture("_BaseMap", imageInfo.texture);
            spawned.transform.localScale = new
            Vector3(defaultScale, defaultScale, 1.0f);
            InteractionController.EnableMode("Main");
        }
    }
}