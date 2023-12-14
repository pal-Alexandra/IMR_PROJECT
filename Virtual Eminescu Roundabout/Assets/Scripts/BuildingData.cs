using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewBuildingData", menuName = "Building Data")]
public class BuildingData : ScriptableObject
{
    public string buildingName;
    public string description;
    public Sprite buildingImage;

    public void Print()
    {
        Debug.Log(buildingName + " : " + description);
    }
}
