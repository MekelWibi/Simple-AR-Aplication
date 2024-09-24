
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PlaceObjectOnPlane : MonoBehaviour
{
    [SerializeField]
    GameObject placedPrefab;
    GameObject spawnedObject;
    [SerializeField] GameObject addUICanvas;
    [SerializeField] GameObject editUICanvas;
    [SerializeField] GameObject mainUICanvas;
    public GameObject selectedGameObject;

    void OnPlaceObject(InputValue inputValue)
    {
        if (addUICanvas.active)
        {
            // get the screen touch position
            Vector2 touchPosition = inputValue.Get<Vector2>();
            // raycast from the touch position into the 3D scene looking for a plane
            // if the raycast hit a plane then
            ARRaycastManager raycaster = GetComponent<ARRaycastManager>();
            List<ARRaycastHit> hits = new List<ARRaycastHit>();

            if (raycaster.Raycast(touchPosition, hits, TrackableType.PlaneWithinPolygon))
            {
                // get the hit point (pose) on the plane
                Pose hitPose = hits[0].pose;
                // if this is the first time placing an object,
                if (spawnedObject == null)
                {
                    // instantiate the prefab at the hit position and rotation
                    spawnedObject = Instantiate(placedPrefab,
                    hitPose.position, hitPose.rotation);
                }
                else
                {
                    // change the position of the previously instantiated object
                    spawnedObject.transform.SetPositionAndRotation(
                        hitPose.position, hitPose.rotation);
                }
            }

            // else
            // change the position of the previously instantiated object

        }

    }

    void SelectedObject(InputValue inputValue)
    {
        Vector2 touchPosition = inputValue.Get<Vector2>();

        // Convert the screen touch position into a Ray
        Ray ray = Camera.main.ScreenPointToRay(touchPosition);
        RaycastHit hit;

        // Check if the Ray hits any object in the scene
        if (Physics.Raycast(ray, out hit))
        {
            // Check if the hit object is the spawned object
            if (hit.transform.gameObject == spawnedObject)
            {
                // Set the selected game object to the hit object
                selectedGameObject = spawnedObject;

                // Switch to the Edit UI and hide the Main UI
                editUICanvas.SetActive(true);
                mainUICanvas.SetActive(false);
            }
        }
    }

}
