using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using static Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics;

public class BCU_click : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{

    private List<GameObject> allTreasures;
    [SerializeField]
    
    private GameObject dynamicInfoPanel;
    private BuildingInfoPanel infoPanelScript;
    
    [SerializeField]
    private BuildingData BCUbuildingData;



    private void Awake()
    {
        //Debug.Log("awake from bcu_click");
        allTreasures = new List<GameObject>(GameObject.FindGameObjectsWithTag("Treasure"));
        if (dynamicInfoPanel != null)
        {
            infoPanelScript = dynamicInfoPanel.GetComponent<BuildingInfoPanel>();
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //Debug.Log("pointer down bcu");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //Debug.Log("pointer up bcu");
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        //Debug.Log("pointer CLICK bcu");
        CheckBookIsCollected();

    }

    private GameObject getBCUTreasure()
    {
        GameObject book = null;
        for (int i = 0; i <= allTreasures.Count - 1; i++)
        {
            string collectedTreasureName = allTreasures[i].name;
            if (collectedTreasureName == "Book")
            {
                Debug.Log("I found the book");
                book = allTreasures[i];
                break;
            }

        }
        return book;
    } 

    private void CheckBookIsCollected()
    {
        Debug.Log("I'm in CheckBookIsCollected");
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

    public void OnPointerEnter(PointerEventData eventData)
    {
        //Debug.Log("pointer enter bcu");

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //Debug.Log("pointer exit bcu");

    }



}

