using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TreasurePickupEvent : MonoBehaviour
{
    private XRGrabInteractable grabInteractable;
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip pickupSound;


    private void Start()
    {
        XRBaseInteractable interactable = GetComponent<XRBaseInteractable>();
    }

    private void Awake()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        audioSource = GetComponent<AudioSource>();
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
        PlaySound(pickupSound);
        gameObject.SetActive(false);
        Debug.Log("Object picked up");
    }

    private void OnDrop(SelectExitEventArgs args)
    {
        Debug.Log("Object dropped");
    }

    private void PlaySound(AudioClip clip)
    {
        if (clip != null && audioSource != null)
        {
            audioSource.PlayOneShot(clip);
        }
    }
}
