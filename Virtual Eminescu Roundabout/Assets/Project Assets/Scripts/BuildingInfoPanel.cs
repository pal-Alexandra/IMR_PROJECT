using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BuildingInfoPanel : MonoBehaviour
{
    private BuildingData currentBuildingData;

    [SerializeField] 
    private TextMeshProUGUI buildingTitleText;
    [SerializeField] 
    private TextMeshProUGUI buildingBodyText;
    [SerializeField] 
    private Image buildingImage;
    [SerializeField] 
    private Button openURLButton;

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
