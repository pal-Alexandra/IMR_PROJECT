using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CCS_clicked : MonoBehaviour, IPointerClickHandler
{
    private List<GameObject> allTreasures;
    [SerializeField]

    private GameObject dynamicInfoPanel;
    private BuildingInfoPanel infoPanelScript;

    [SerializeField]
    private BuildingData CCSbuildingData;



    private void Awake()
    {
        Debug.Log("CCS AWAKE");
        allTreasures = new List<GameObject>(GameObject.FindGameObjectsWithTag("Treasure"));
        if (dynamicInfoPanel != null)
        {
            infoPanelScript = dynamicInfoPanel.GetComponent<BuildingInfoPanel>();
        }
    }

    private void OnMouseUpAsButton()
    {
        Debug.Log("CCS CLICKED!!!");
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("pointer CLICK CCS");
        CheckRedbullIsCollected();

    }

    private GameObject getCCSTreasure()
    {
        GameObject redbull = null;
        for (int i = 0; i <= allTreasures.Count - 1; i++)
        {
            string collectedTreasureName = allTreasures[i].name;
            if (collectedTreasureName == "Redbull")
            {
                Debug.Log("I found the redbull");
                redbull = allTreasures[i];
                break;
            }

        }
        return redbull;
    }

    private void CheckRedbullIsCollected()
    {
        //Debug.Log("I'm in CheckRedbullIsCollected");
        GameObject redbull = getCCSTreasure();

        if (redbull)
        {
            if (redbull.activeInHierarchy == false)
            {
                //I can see info on dynamic panel, so I have to update the dynamic panel
                Debug.Log("YAY redbull is colected");
                UpdateDynamicPanel();

            }
            else
            {
                //I can not see info on dynamic panel, so I don't update the dynamic panel
                Debug.Log("NAY Redbull is NOT colected");
            }
        }

    }

    private void UpdateDynamicPanel()
    {
        if (infoPanelScript != null)
        {
            infoPanelScript.UpdatePanel(CCSbuildingData);
        }

    }

}
