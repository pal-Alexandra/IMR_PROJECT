using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreboardManager : MonoBehaviour
{
    private string text;
    private List<GameObject> allTreasures;

    private void Start()
    {
        allTreasures = new List<GameObject>(GameObject.FindGameObjectsWithTag("Treasure"));
    }

    private void Update()
    {
        UpdateScoreboard();
    }

    private void UpdateScoreboard()
    {
        int collectedCount = 0;
        foreach (var treasure in allTreasures)
        {
            if (!treasure.activeInHierarchy)
            {
                collectedCount++;
            }
        }

        int totalCount = allTreasures.Count;
        text = "Collected Treasures: " + collectedCount + " / " + totalCount;
        print(text);
    }
}
