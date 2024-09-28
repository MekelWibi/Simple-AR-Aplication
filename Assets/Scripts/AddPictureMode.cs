using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
public class AddPictureMode : MonoBehaviour
{
    [SerializeField] GameObject placedPrefab;
    List<ARRaycastHit> hits = new List<ARRaycastHit>();
    void OnEnable()
    {
        UIController.ShowUI("AddPicture");
    }
    public void OnPlaceObject(InputValue value)
    {
        Vector2 touchPosition = value.Get<Vector2>();
        PlaceObject(touchPosition);
    }
    void PlaceObject(Vector2 touchPosition)
    {
        ARRaycastManager raycaster = GetComponent<ARRaycastManager>();
        if (raycaster.Raycast(touchPosition, hits,
        TrackableType.PlaneWithinPolygon))
        {
            Pose hitPose = hits[0].pose;
            Instantiate(placedPrefab, hitPose.position,
            hitPose.rotation);
            InteractionController.EnableMode("Main");
        }
    }
}