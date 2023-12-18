using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressPanel : MonoBehaviour
{

    private Image blue_flower_image;
    private Image tr_2_image;
    private Image tr_3_image;
    private Image tr_4_image;

    void Start()
    {
        blue_flower_image = transform.Find("Treasure_hunt_1").GetComponentInChildren<Image>();
        tr_2_image = transform.Find("Treasure_hunt_2").GetComponentInChildren<Image>();
        tr_3_image = transform.Find("Treasure_hunt_3").GetComponentInChildren<Image>();
        tr_4_image = transform.Find("Treasure_hunt_4").GetComponentInChildren<Image>();

    }

    void UpdatePanel(Progress_images progress_images, int flag)
    {
        if (flag == 1) {

            blue_flower_image.sprite = progress_images.blueFlower;

        }else if (flag == 2)
        {
            tr_2_image.sprite = progress_images.tr_2;
        }else if (flag == 3)
        {
            tr_3_image.sprite = progress_images.tr_3;
        }
        else
        {
            tr_4_image.sprite = progress_images.tr_4;
        }



        
    }
}
