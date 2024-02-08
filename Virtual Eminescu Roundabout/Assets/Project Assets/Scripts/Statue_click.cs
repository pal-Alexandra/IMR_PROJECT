using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Statue_click : MonoBehaviour, IPointerClickHandler
{
    private List<GameObject> allTreasures;
    [SerializeField]

    private GameObject dynamicInfoPanel;
    private BuildingInfoPanel infoPanelScript;

    [SerializeField]
    private BuildingData StatuebuildingData;



    private void Awake()
    {
        Debug.Log("STATUE AWAKE");
        allTreasures = new List<GameObject>(GameObject.FindGameObjectsWithTag("Treasure"));
        if (dynamicInfoPanel != null)
        {
            infoPanelScript = dynamicInfoPanel.GetComponent<BuildingInfoPanel>();
        }
    }

    private void OnMouseUpAsButton()
    {
        Debug.Log("STATUE CLICKED!!!");
    }


    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Satue clicked");
        CheckFlowerIsCollected();

    }

    private GameObject getStatueTreasure()
    {
        GameObject flower = null;
        for (int i = 0; i <= allTreasures.Count - 1; i++)
        {
            string collectedTreasureName = allTreasures[i].name;
            if (collectedTreasureName == "Blue Flower")
            {
                Debug.Log("I found the flower");
                flower = allTreasures[i];
                break;
            }

        }
        return flower;
    }

    private void CheckFlowerIsCollected()
    {
        //Debug.Log("I'm in CheckFlowerIsCollected");
        GameObject flower = getStatueTreasure();

        if (flower)
        {
            if (flower.activeInHierarchy == false)
            {
                //I can see info on dynamic panel, so I have to update the dynamic panel
                Debug.Log("YAY Flower is colected");
                UpdateDynamicPanel();

            }
            else
            {
                //I can not see info on dynamic panel, so I don't update the dynamic panel
                Debug.Log("NAY Flower is NOT colected");
            }
        }

    }

    private void UpdateDynamicPanel()
    {
        if (infoPanelScript != null)
        {
            infoPanelScript.UpdatePanel(StatuebuildingData);
        }

    }
}
