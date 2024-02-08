using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using static Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics;
using UnityEngine.XR.Interaction.Toolkit;

public class BCU_click : MonoBehaviour
{

    private List<GameObject> allTreasures;
    [SerializeField]
    
    private GameObject dynamicInfoPanel;
    private BuildingInfoPanel infoPanelScript;
    
    [SerializeField]
    private BuildingData BCUbuildingData;

    private XRSimpleInteractable simpleInteractable;

    private void Awake()
    {
        simpleInteractable = GetComponent<XRSimpleInteractable>();
        //Debug.Log("awake from bcu_click");
        allTreasures = new List<GameObject>(GameObject.FindGameObjectsWithTag("Treasure"));
        if (dynamicInfoPanel != null)
        {
            infoPanelScript = dynamicInfoPanel.GetComponent<BuildingInfoPanel>();
        }
    }

    private void OnEnable()
    {
        simpleInteractable.selectEntered.AddListener(OnPickup);
        simpleInteractable.selectExited.AddListener(OnDrop);
    }

    private void OnDisable()
    {
        simpleInteractable.selectEntered.RemoveListener(OnPickup);
        simpleInteractable.selectExited.RemoveListener(OnDrop);
    }

    private void OnPickup(SelectEnterEventArgs args)
    {
        Debug.Log("pointer CLICK bcu");
        CheckBookIsCollected();
    }

    private void OnDrop(SelectExitEventArgs args)
    {
        Debug.Log("Object dropped");
    }

    private GameObject getBCUTreasure()
    {
        GameObject book = null;
        for (int i = 0; i <= allTreasures.Count - 1; i++)
        {
            string collectedTreasureName = allTreasures[i].name;
            if (collectedTreasureName == "Book")
            {
                //Debug.Log("I found the book");
                book = allTreasures[i];
                break;
            }

        }
        return book;
    } 

    private void CheckBookIsCollected()
    {
        //Debug.Log("I'm in CheckBookIsCollected");
        GameObject book = getBCUTreasure();

        if (book)
        {
            if (book.activeInHierarchy == false)
            {
                //I can see info on dynamic panel, so I have to update the dynamic panel
                Debug.Log("YAY Book is colected");
                UpdateDynamicPanel();

            }
            else
            {
                //I can not see info on dynamic panel, so I don't update the dynamic panel
                Debug.Log("NAY Book is NOT colected");
            }
        }

    }

    private void UpdateDynamicPanel()
    {
        if (infoPanelScript != null)
        {
            infoPanelScript.UpdatePanel(BCUbuildingData);
        }

    }
}
