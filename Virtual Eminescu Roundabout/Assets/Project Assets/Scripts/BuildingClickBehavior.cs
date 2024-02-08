using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using static Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics;
using UnityEngine.XR.Interaction.Toolkit;

public class BuildingClickBehavior : MonoBehaviour
{

    private List<GameObject> allTreasures;
    [SerializeField]
    
    private GameObject infoPanel;
    
    [SerializeField]
    private BuildingData BCUbuildingData;

    private XRSimpleInteractable simpleInteractable;
    private BuildingInfoPanel infoPanelScript;

    [SerializeField]
    private AudioClip activeSound;

    [SerializeField]
    private AudioClip inactiveSound;

    private AudioSource audioSource;

    private void Awake()
    {
        simpleInteractable = GetComponent<XRSimpleInteractable>();
        infoPanelScript = infoPanel.GetComponent<BuildingInfoPanel>();
        audioSource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        simpleInteractable.selectEntered.AddListener(OnPickup);
    }

    private void OnDisable()
    {
        simpleInteractable.selectEntered.RemoveListener(OnPickup);
    }

    private void OnPickup(SelectEnterEventArgs args)
    {
        if (IsTreasureCollected())
        {
            UpdateDynamicPanel();
            PlaySound(activeSound);
        }
        else
        {
            PlaySound(inactiveSound);
        }
    }

    private bool IsTreasureCollected()
    {
        return gameObject.tag == "ActiveBuilding";
    }

    private void UpdateDynamicPanel()
    {
        if (infoPanelScript != null)
        {
            infoPanelScript.UpdatePanel(BCUbuildingData);
        }
    }

    private void PlaySound(AudioClip clip)
    {
        if (audioSource != null && clip != null)
        {
            audioSource.PlayOneShot(clip);
        }
    }
}

