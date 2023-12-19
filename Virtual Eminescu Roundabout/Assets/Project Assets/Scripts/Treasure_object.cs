using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treasure_object : MonoBehaviour
{
    [SerializeField]
    private Progress_images progress_images;

    [SerializeField]
    private int flag;

    [SerializeField]
    private GameObject progressPanel;

    public void FoundObject()
    {
        ProgressPanel script = progressPanel.GetComponent<ProgressPanel>();

        if (script != null)
        {
            script.UpdatePanel(progress_images, flag);
        }

    }
}
