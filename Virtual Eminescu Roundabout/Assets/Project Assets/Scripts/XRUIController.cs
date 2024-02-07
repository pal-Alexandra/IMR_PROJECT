 using UnityEngine;
using UnityEngine.UI;

public class XRUIController : MonoBehaviour
{
    public Button[] buttons;
    public Slider volumeSlider;

    void Start()
    {
        foreach (Button button in buttons)
        {
            button.onClick.AddListener(() => ButtonClicked(button));
        }

        volumeSlider.onValueChanged.AddListener(delegate { SliderChanged(); });
    }

    void ButtonClicked(Button button)
    {
        Debug.Log("Pressed Button: " + button.gameObject.name);
    }

    void SliderChanged()
    {
        Debug.Log("Slider Value: " + volumeSlider.value);
    }
}
