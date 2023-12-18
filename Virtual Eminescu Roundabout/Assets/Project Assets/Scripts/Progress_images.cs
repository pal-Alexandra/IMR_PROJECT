using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewProgressImages", menuName = "Progress Images")]
public class Progress_images : ScriptableObject
{
    public Sprite blueFlower;
    public Sprite tr_2;
    public Sprite tr_3;
    public Sprite tr_4;


    public void Print()
    {
        //Debug.Log(buildingName + " : " + description);
    }
}
