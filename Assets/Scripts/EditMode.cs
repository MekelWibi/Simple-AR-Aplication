using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditMode : MonoBehaviour
{
    void OnEnable()
    {
        UIController.ShowUI("Edit");
    }
}
