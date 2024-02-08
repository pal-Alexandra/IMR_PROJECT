using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TreasurePickupEvent : MonoBehaviour
{
    private XRGrabInteractable grabInteractable;

    private void Start()
    {
        XRBaseInteractable interactable = GetComponent<XRBaseInteractable>();
    }

    private void Awake()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
    }

    private void OnEnable()
    {
        grabInteractable.selectEntered.AddListener(OnPickup);
        grabInteractable.selectExited.AddListener(OnDrop);
    }

    private void OnDisable()
    {
        grabInteractable.selectEntered.RemoveListener(OnPickup);
        grabInteractable.selectExited.RemoveListener(OnDrop);
    }

    private void OnPickup(SelectEnterEventArgs args)
    {
        gameObject.SetActive(false);
        Debug.Log("Object picked up");
    }

    private void OnDrop(SelectExitEventArgs args)
    {
        Debug.Log("Object dropped");
    }
}
