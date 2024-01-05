using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressPanel : MonoBehaviour
{

    private Image blueFlowerImage;
    private Image bookImage;
    private Image bearImage;
    private Image redbullImage;

    void Start()
    {
        blueFlowerImage = transform.Find("Treasure_hunt_1").GetComponentInChildren<Image>();
        bookImage = transform.Find("Treasure_hunt_2").GetComponentInChildren<Image>();
        bearImage = transform.Find("Treasure_hunt_3").GetComponentInChildren<Image>();
        redbullImage = transform.Find("Treasure_hunt_4").GetComponentInChildren<Image>();
    }

    public void UpdatePanel(ProgressImages progressImages, int flag)
    {
        if (flag == 1)
        {
            blueFlowerImage.sprite = progressImages.blue_flower;
        }
        else if (flag == 2)
        {
            bookImage.sprite = progressImages.book;
        }
        else if (flag == 3)
        {
            bearImage.sprite = progressImages.bear;
        }
        else if (flag == 4)
        {
            redbullImage.sprite = progressImages.redbull;
        }
    }
}
