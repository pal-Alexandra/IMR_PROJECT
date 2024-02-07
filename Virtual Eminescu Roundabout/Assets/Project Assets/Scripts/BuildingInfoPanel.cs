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
    private AudioClip buildingAudioClip;
    [SerializeField] 
    private Button speakButton;

    private AudioSource audioSource;


    public void UpdatePanel(BuildingData buildingData)
    {
        currentBuildingData = buildingData;

        buildingTitleText.text = currentBuildingData.buildingName;
        buildingBodyText.text = currentBuildingData.description;
        buildingImage.sprite = currentBuildingData.buildingImage;
        buildingAudioClip = currentBuildingData.buildingSpeakingInfo;

        audioSource = GetComponent<AudioSource>();

        speakButton.onClick.RemoveAllListeners();
        speakButton.onClick.AddListener(SpeakInformation);

    }

    public void SpeakInformation()
    {
        print("button pressed");
        if (buildingAudioClip != null && audioSource != null)
        {
            print("button effect");
            audioSource.PlayOneShot(buildingAudioClip);
        }
    }
}
