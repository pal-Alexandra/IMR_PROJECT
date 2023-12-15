using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    [SerializeField]
    private BuildingData buildingData;
    [SerializeField]
    private GameObject infoPanel;

    public void Start()
    {
        Debug.Log("pisica");
        BuildingInfoPanel script = infoPanel.GetComponent<BuildingInfoPanel>();

        if (script != null)
        {
            script.UpdatePanel(buildingData);
        }

    }
}
