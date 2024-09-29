using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public GameObject addPanel;
    public GameObject mainPanel;
    public GameObject editPanel;
    public GameObject selectImagePanel;
    [SerializeField] AddPictureMode addPicture;
    [SerializeField] ImagesData imagesData;

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


    public void SelectImages0()
    {
        Texture texture = imagesData.images[0].texture;
        addPicture.imageInfo.texture = texture;
        addPicture.imageInfo.width = 512; // Set the specific width
        addPicture.imageInfo.height = 1024; // Set the specific height
        // Switch panels and enable the appropriate mode
        selectImagePanel.SetActive(false);
        addPanel.SetActive(true);
        InteractionController.EnableMode("AddPicture");
    }

    public void SelectImages1()
    {
        Texture texture = imagesData.images[1].texture;
        addPicture.imageInfo.texture = texture;
        addPicture.imageInfo.width = 512; // Set the specific width
        addPicture.imageInfo.height = 1024; // Set the specific height
        // Switch panels and enable the appropriate mode
        selectImagePanel.SetActive(false);
        addPanel.SetActive(true);
        InteractionController.EnableMode("AddPicture");
    }

    public void SelectImages2()
    {
        Texture texture = imagesData.images[2].texture;
        addPicture.imageInfo.texture = texture;
        addPicture.imageInfo.width = 512; // Set the specific width
        addPicture.imageInfo.height = 1024; // Set the specific height
        // Switch panels and enable the appropriate mode
        selectImagePanel.SetActive(false);
        addPanel.SetActive(true);
        InteractionController.EnableMode("AddPicture");
    }

    public void SelectImages3()
    {
        Texture texture = imagesData.images[3].texture;
        addPicture.imageInfo.texture = texture;
        addPicture.imageInfo.width = 512; // Set the specific width
        addPicture.imageInfo.height = 1024; // Set the specific height
        // Switch panels and enable the appropriate mode
        selectImagePanel.SetActive(false);
        addPanel.SetActive(true);
        InteractionController.EnableMode("AddPicture");
    }

    public void SelectImages4()
    {
        Texture texture = imagesData.images[4].texture;
        addPicture.imageInfo.texture = texture;
        addPicture.imageInfo.width = 512; // Set the specific width
        addPicture.imageInfo.height = 1024; // Set the specific height
        // Switch panels and enable the appropriate mode
        selectImagePanel.SetActive(false);
        addPanel.SetActive(true);
        InteractionController.EnableMode("AddPicture");
    }

    public void SelectImages5()
    {
        Texture texture = imagesData.images[5].texture;
        addPicture.imageInfo.texture = texture;
        addPicture.imageInfo.width = 512; // Set the specific width
        addPicture.imageInfo.height = 1024; // Set the specific height
        // Switch panels and enable the appropriate mode
        selectImagePanel.SetActive(false);
        addPanel.SetActive(true);
        InteractionController.EnableMode("AddPicture");
    }

    public void SelectImages6()
    {
        Texture texture = imagesData.images[6].texture;
        addPicture.imageInfo.texture = texture;
        addPicture.imageInfo.width = 512; // Set the specific width
        addPicture.imageInfo.height = 1024; // Set the specific height
        // Switch panels and enable the appropriate mode
        selectImagePanel.SetActive(false);
        addPanel.SetActive(true);
        InteractionController.EnableMode("AddPicture");
    }

    public void SelectImages7()
    {
        Texture texture = imagesData.images[7].texture;
        addPicture.imageInfo.texture = texture;
        addPicture.imageInfo.width = 512; // Set the specific width
        addPicture.imageInfo.height = 1024; // Set the specific height
        // Switch panels and enable the appropriate mode
        selectImagePanel.SetActive(false);
        addPanel.SetActive(true);
        InteractionController.EnableMode("AddPicture");
    }

    public void SelectImages8()
    {
        Texture texture = imagesData.images[8].texture;
        addPicture.imageInfo.texture = texture;
        addPicture.imageInfo.width = 512; // Set the specific width
        addPicture.imageInfo.height = 1024; // Set the specific height
        // Switch panels and enable the appropriate mode
        selectImagePanel.SetActive(false);
        addPanel.SetActive(true);
        InteractionController.EnableMode("AddPicture");
    }
}
