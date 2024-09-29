using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public GameObject addPanel;
    public GameObject mainPanel;
    public GameObject editPanel;
    public GameObject selectImagePanel;

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

    public void SelectImagetoMainPanel()
    {
        selectImagePanel.SetActive(false);
        mainPanel.SetActive(true);
    }

    public void ShowSelectImageUIPanel()
    {
        selectImagePanel.SetActive(true);
        mainPanel.SetActive(false);
    }

}
