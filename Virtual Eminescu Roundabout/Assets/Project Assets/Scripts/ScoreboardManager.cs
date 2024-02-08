using System.Collections.Generic;
using UnityEngine;

public class ScoreboardManager : MonoBehaviour
{
    private List<GameObject> allTreasures;
    private ProgressPanel progressPanelScript;

    private AudioSource audioSource;

    [SerializeField]
    private ProgressImages progressImages;

    [SerializeField]
    private GameObject progressPanel;

    [SerializeField]
    private AudioClip pickupSound;

    [SerializeField]
    private GameObject BCUBuilding;
    [SerializeField]
    private GameObject CCSBuilding;
    [SerializeField]
    private GameObject PCBuilding;
    [SerializeField]
    private GameObject StatueBuilding;



    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

        allTreasures = new List<GameObject>(GameObject.FindGameObjectsWithTag("Treasure"));
        if (progressPanel != null)
        {
            progressPanelScript = progressPanel.GetComponent<ProgressPanel>();
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
                UpdateProgressPanel(collectedTreasureName);
                ModifyBuildingTagBasedOnFlag(collectedTreasureName);
                allTreasures.RemoveAt(i);
                PlaySound(pickupSound);
            }
        }
    }

    private void UpdateProgressPanel(string collectedTreasureName)
    {
        if (progressPanelScript == null) return;

        int flag = DetermineFlagFromTreasureName(collectedTreasureName);
        progressPanelScript.UpdatePanel(progressImages, flag);
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

    private void ModifyBuildingTagBasedOnFlag(string collectedTreasureName)
    {
        int flag = DetermineFlagFromTreasureName(collectedTreasureName);
        switch (flag)
        {
            case 1:
                StatueBuilding.tag = "ActiveBuilding";
                break;
            case 2:
                BCUBuilding.tag = "ActiveBuilding";
                break;
            case 3:
                PCBuilding.tag = "ActiveBuilding";
                break;
            case 4:
                CCSBuilding.tag = "ActiveBuilding";
                break;
            default:
                break;
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
