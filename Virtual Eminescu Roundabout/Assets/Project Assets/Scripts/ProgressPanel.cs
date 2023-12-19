using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressPanel : MonoBehaviour
{

    private Image blue_flower_image;
    private Image book_image;
    private Image bear_image;
    private Image redbull_image;

    void Start()
    {
        blue_flower_image = transform.Find("Treasure_hunt_1").GetComponentInChildren<Image>();
        book_image = transform.Find("Treasure_hunt_2").GetComponentInChildren<Image>();
        bear_image = transform.Find("Treasure_hunt_3").GetComponentInChildren<Image>();
        redbull_image = transform.Find("Treasure_hunt_4").GetComponentInChildren<Image>();

    }

    public void UpdatePanel(Progress_images progress_images, int flag)
    {
        if (flag == 1) {

            blue_flower_image.sprite = progress_images.blue_flower;

        }else if (flag == 2)
        {
            book_image.sprite = progress_images.book;
        }else if (flag == 3)
        {
            bear_image.sprite = progress_images.bear;
        }
        else
        {
            redbull_image.sprite = progress_images.redbull;
        }



        
    }
}
