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
    private Button speakButton;

    private AudioSource audioSource;
    private AudioClip buildingAudioClip;
    private bool isAudioPlaying = false;

    [SerializeField]
    private float distanceFromPlayer = 5f;
    [SerializeField]
    private float heightOffset = 1.5f;
    [SerializeField]
    private Transform playerCameraTransform;

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

        MovePanelInFrontOfPlayer();
    }

    public void SpeakInformation()
    {
        if (buildingAudioClip != null && audioSource != null)
        {
            if (isAudioPlaying)
            {
                audioSource.Stop();
                isAudioPlaying = false;
            }
            else
            {
                audioSource.PlayOneShot(buildingAudioClip);
                isAudioPlaying = true;
            }
        }
    }

    private void MovePanelInFrontOfPlayer()
    {
        if (playerCameraTransform == null) return;

        Vector3 newPosition = playerCameraTransform.position + playerCameraTransform.forward * distanceFromPlayer;
        newPosition.y += heightOffset;
        transform.position = newPosition;

        Vector3 directionToFace = playerCameraTransform.position - transform.position;

        Quaternion initialRotation = Quaternion.LookRotation(directionToFace);
        Quaternion correctedRotation = Quaternion.Euler(0, initialRotation.eulerAngles.y + 180, 0);

        transform.rotation = correctedRotation;
    }
}
