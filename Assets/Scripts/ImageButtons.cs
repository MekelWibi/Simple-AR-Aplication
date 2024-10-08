using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ImageButtons : MonoBehaviour
{
    [SerializeField] GameObject imageButtonPrefab;
    [SerializeField] ImagesData imagesData;
    [SerializeField] AddPictureMode addPicture;
    [SerializeField] GameObject selectImagePanel;
    [SerializeField] GameObject addPanel;
    void Start()
    {
        for (int i = transform.childCount - 1; i >= 0; i--)
        {
            GameObject.Destroy(
             transform.GetChild(i).gameObject);
        }
        foreach (ImageInfo image in imagesData.images)
        {
            GameObject obj =
            Instantiate(imageButtonPrefab, transform);
            RawImage rawimage = obj.GetComponent<RawImage>();
            rawimage.texture = image.texture;
            Button button = obj.GetComponent<Button>();
            button.onClick.AddListener(() => OnClick(image));
        }
    }
    public void OnClick(ImageInfo image)
    {
        addPicture.imageInfo = image;
        selectImagePanel.SetActive(false);
        addPanel.SetActive(true);
        InteractionController.EnableMode("AddPicture");
    }
}