using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public GameObject addPanel;
    public GameObject mainPanel;

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
}
