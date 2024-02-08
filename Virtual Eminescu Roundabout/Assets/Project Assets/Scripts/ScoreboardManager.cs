using System.Collections.Generic;
using UnityEngine;

public class ScoreboardManager : MonoBehaviour
{
    private List<GameObject> allTreasures;
    private ProgressPanel progressPanelScript;
    private BuildingInfoPanel infoPanelScript;

    private AudioSource audioSource;

    [SerializeField]
    private ProgressImages progressImages;

    [SerializeField]
    private GameObject progressPanel;

    [SerializeField]
    private GameObject infoPanel;

    [SerializeField]
    private BuildingData BCUbuildingData;
    [SerializeField]
    private BuildingData CCSbuildingData;
    [SerializeField]
    private BuildingData PCbuildingData;
    [SerializeField]
    private BuildingData StatuebuildingData;

    [SerializeField]
    private AudioClip pickupSound;


    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        allTreasures = new List<GameObject>(GameObject.FindGameObjectsWithTag("Treasure"));
        if (progressPanel != null)
        {
            progressPanelScript = progressPanel.GetComponent<ProgressPanel>();
        }
        if (infoPanel != null)
        {
            infoPanelScript = infoPanel.GetComponent<BuildingInfoPanel>();
            infoPanel.SetActive(false);
        }
    }

    private void Update()
    {
        CheckForCollectedTreasures();
    }

    private void CheckForCollectedTreasures()
    {
        for (int i = allTreasures.Count - 1; i >= 0; i--)
        {
            if (!allTreasures[i].activeInHierarchy)
            {
                string collectedTreasureName = allTreasures[i].name;
                UpdatePanels(collectedTreasureName);
                allTreasures.RemoveAt(i);
                PlaySound(pickupSound);
            }
        }
    }

    private void UpdatePanels(string collectedTreasureName)
    {
        if (progressPanelScript == null) return;

        if (infoPanel != null && !infoPanel.activeSelf)
        {
            infoPanel.SetActive(true);
        }

        int flag = DetermineFlagFromTreasureName(collectedTreasureName);
        progressPanelScript.UpdatePanel(progressImages, flag);

        if (infoPanelScript != null)
        {
            BuildingData buildingData = GetBuildingDataBasedOnFlag(flag);
            infoPanelScript.UpdatePanel(buildingData);
        }
    }

    private int DetermineFlagFromTreasureName(string treasureName)
    {
        switch (treasureName)
        {
            case "Blue Flower":
                return 1;
            case "Book":
                return 2;
            case "Toy Bear":
                return 3;
            case "Redbull":
                return 4;
            default:
                return 0;
        }
    }

    private BuildingData GetBuildingDataBasedOnFlag(int flag)
    {
        switch (flag)
        {
            case 1:
                return StatuebuildingData;
            case 2:
                return BCUbuildingData;
            case 3:
                return PCbuildingData;
            case 4:
                return CCSbuildingData;
            default:
                return null;
        }
    }

    private void PlaySound(AudioClip clip)
    {
        if (clip != null && audioSource != null)
        {
            audioSource.PlayOneShot(clip);
        }
    }
}
