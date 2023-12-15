using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingInfoPanel : MonoBehaviour
{
    public Text buildingNameText;
    public Text descriptionText;
    public Image buildingImage;
    public Button openURLButton;

    public BuildingData currentBuildingData;

    public void UpdatePanel(BuildingData buildingData)
    {

        currentBuildingData = buildingData;

        buildingNameText.text = buildingData.buildingName;
        descriptionText.text = buildingData.description;
        buildingImage.sprite = buildingData.buildingImage;



        openURLButton.onClick.RemoveAllListeners();
        openURLButton.onClick.AddListener(OpenURL);

    }

    public void OpenURL()
    {
        if (currentBuildingData != null && !string.IsNullOrEmpty(currentBuildingData.buildingURL))
        {
            Application.OpenURL(currentBuildingData.buildingURL);
        }
    }

}
