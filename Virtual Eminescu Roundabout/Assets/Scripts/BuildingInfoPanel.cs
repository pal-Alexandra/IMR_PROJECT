using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingInfoPanel : MonoBehaviour
{
    public Text buildingNameText;
    public Text descriptionText;
    public Image buildingImage;

    public void UpdatePanel(BuildingData buildingData)
    {
        buildingNameText.text = buildingData.buildingName;
        descriptionText.text = buildingData.description;
        buildingImage.sprite = buildingData.buildingImage;
    }
}
