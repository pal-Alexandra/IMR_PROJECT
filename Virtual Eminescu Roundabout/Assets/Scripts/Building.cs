using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public BuildingData buildingData;

    public void Start()
    {
        buildingData.Print();
    }
}
