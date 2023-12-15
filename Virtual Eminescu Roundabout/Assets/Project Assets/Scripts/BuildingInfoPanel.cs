using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BuildingInfoPanel : MonoBehaviour
{
    private TextMeshProUGUI buildingTitleText;
    private TextMeshProUGUI buildingBodyText;
    private Image buildingImage;
    private Button openURLButton;

    private BuildingData currentBuildingData;

    public void Start()
    {
        buildingTitleText = transform.Find("Building_title").GetComponentInChildren<TextMeshProUGUI>();
        buildingBodyText = transform.Find("Building_body").GetComponentInChildren<TextMeshProUGUI>();
        buildingImage = transform.Find("Building_image").GetComponentInChildren<Image>();
        openURLButton = transform.Find("Building_button").GetComponentInChildren<Button>();
    }
    public void UpdatePanel(BuildingData buildingData)
    {
        currentBuildingData = buildingData;

        buildingTitleText.text = currentBuildingData.buildingName;
        buildingBodyText.text = currentBuildingData.description;
        buildingImage.sprite = currentBuildingData.buildingImage;

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
