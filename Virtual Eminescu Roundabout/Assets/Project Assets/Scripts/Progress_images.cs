using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewProgressImages", menuName = "Progress Images")]
public class Progress_images : ScriptableObject
{
    public Sprite blue_flower;
    public Sprite book;
    public Sprite bear;
    public Sprite redbull;


    public void Print()
    {
        //Debug.Log(buildingName + " : " + description);
    }
}
