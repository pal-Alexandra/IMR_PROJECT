using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PC_clicked : MonoBehaviour,  IPointerClickHandler
{
    private List<GameObject> allTreasures;
    [SerializeField]

    private GameObject dynamicInfoPanel;
    private BuildingInfoPanel infoPanelScript;

    [SerializeField]
    private BuildingData PCbuildingData;



    private void Awake()
    {
        Debug.Log("PC AWAKE");
        allTreasures = new List<GameObject>(GameObject.FindGameObjectsWithTag("Treasure"));
        if (dynamicInfoPanel != null)
        {
            infoPanelScript = dynamicInfoPanel.GetComponent<BuildingInfoPanel>();
        }
    }


    private void OnMouseUpAsButton()
    {
        Debug.Log("PC CLICKED!!!");
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("pointer CLICK pc");
        CheckBearIsCollected();

    }

    private GameObject getPCTreasure()
    {
        GameObject bear = null;
        for (int i = 0; i <= allTreasures.Count - 1; i++)
        {
            string collectedTreasureName = allTreasures[i].name;
            if (collectedTreasureName == "Toy Bear")
            {
                Debug.Log("I found the bear");
                bear = allTreasures[i];
                break;
            }

        }
        return bear;
    }

    private void CheckBearIsCollected()
    {
        //Debug.Log("I'm in CheckBearIsCollected");
        GameObject bear = getPCTreasure();

        if (bear)
        {
            if (bear.activeInHierarchy == false)
            {
                //I can see info on dynamic panel, so I have to update the dynamic panel
                Debug.Log("YAY Bear is colected");
                UpdateDynamicPanel();

            }
            else
            {
                //I can not see info on dynamic panel, so I don't update the dynamic panel
                Debug.Log("NAY Bear is NOT colected");
            }
        }

    }

    private void UpdateDynamicPanel()
    {
        if (infoPanelScript != null)
        {
            infoPanelScript.UpdatePanel(PCbuildingData);
        }

    }

}