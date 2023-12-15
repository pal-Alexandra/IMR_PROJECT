using UnityEngine;

public class Building : MonoBehaviour
{
    [SerializeField]
    private BuildingData buildingData;
    [SerializeField]
    private GameObject infoPanel;

    public void Start()
    {
        BuildingInfoPanel script = infoPanel.GetComponent<BuildingInfoPanel>();

        if (script != null)
        {
            script.UpdatePanel(buildingData);
        }

    }
}
