using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.InputSystem;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class AddMode : MonoBehaviour
{

    void OnEnable()
    {
        UIController.ShowUI("Add");
    }

}
