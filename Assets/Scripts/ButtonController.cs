using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public GameObject addPanel;
    public GameObject mainPanel;
    public GameObject editPanel;

    public void ShowAddPanel()
    {
        mainPanel.SetActive(false);
        addPanel.SetActive(true);
    }

    public void ShowMainUIPanel()
    {
        addPanel.SetActive(false);
        mainPanel.SetActive(true);
    }

    public void ShowEditUIPanel()
    {
        mainPanel.SetActive(false);
        editPanel.SetActive(true);
    }

    public void EdittoMainPanel()
    {
        editPanel.SetActive(false);
        mainPanel.SetActive(true);
    }

}
