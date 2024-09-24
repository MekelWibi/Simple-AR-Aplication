using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMode : MonoBehaviour
{
    [SerializeField] PlaceObjectOnPlane placeObjectOnPlane;

    void OnEnable()
    {
        UIController.ShowUI("Main");
    }
    // todo RAdd Main mode interactions
}