using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System.Collections.Generic;

public class XRUIController : MonoBehaviour
{
    [SerializeField]
    private Button[] seasonButtons;
    [SerializeField]
    private Button[] weatherButtons;
    [SerializeField]
    private Button[] timeOfDayButtons;

    [SerializeField]
    private Slider volumeSlider;

    [SerializeField]
    private Material daySunnySky;
    [SerializeField]
    private Material nightSunnySky;
    [SerializeField]
    private Material rainSnowDaySky;
    [SerializeField]
    private Material rainSnowNightSky;

    [SerializeField]
    private GameObject rainEffect;
    [SerializeField]
    private GameObject snowEffect;

    [SerializeField]
    private GameObject springAndSummerTerrain;
    [SerializeField]
    private GameObject autumnTerrain;
    [SerializeField]
    private GameObject winterTerrainAndObjects;

    private string selectedSeason = "Spring";
    private string selectedWeather = "Sunny";
    private string selectedTimeOfDay = "Day";

    private GameObject currentRainEffect = null;

    void Start()
    {
        InitializeButtons(seasonButtons, selectedSeason);
        InitializeButtons(weatherButtons, selectedWeather);
        InitializeButtons(timeOfDayButtons, selectedTimeOfDay);

        volumeSlider.value = 50;
        SliderChanged();

        foreach (Button button in seasonButtons)
        {
            button.onClick.AddListener(() => SeasonButtonClicked(button));
        }

        foreach (Button button in weatherButtons)
        {
            button.onClick.AddListener(() => WeatherButtonClicked(button));
        }

        foreach (Button button in timeOfDayButtons)
        {
            button.onClick.AddListener(() => TimeOfDayButtonClicked(button));
        }

        volumeSlider.onValueChanged.AddListener(delegate { SliderChanged(); });

        UpdateEnvironment();
    }

    void InitializeButtons(Button[] buttons, string defaultValue)
    {
        foreach (Button button in buttons)
        {
            if (button.gameObject.name == defaultValue)
            {
                SelectButton(button);
            }
            else
            {
                DeselectButton(button);
            }
        }
    }

    void SeasonButtonClicked(Button button)
    {
        string newSeason = button.gameObject.name;

        if (newSeason != "Winter" && selectedWeather == "Snowy")
        {
            selectedWeather = "Rainy";
            UpdateButtonSelection(weatherButtons, weatherButtons.First(b => b.gameObject.name == "Rainy"));
        }

        selectedSeason = newSeason;
        UpdateButtonSelection(seasonButtons, button);
        UpdateEnvironment();
    }

    void WeatherButtonClicked(Button button)
    {
        if (selectedSeason != "Winter" && button.gameObject.name == "Snowy")
            return;

        selectedWeather = button.gameObject.name;
        UpdateButtonSelection(weatherButtons, button);
        UpdateEnvironment();
    }

    void TimeOfDayButtonClicked(Button button)
    {
        selectedTimeOfDay = button.gameObject.name;
        UpdateButtonSelection(timeOfDayButtons, button);
        UpdateEnvironment();
    }

    void UpdateButtonSelection(Button[] buttons, Button selectedButton)
    {
        foreach (Button button in buttons)
        {
            if (button == selectedButton)
            {
                SelectButton(button);
            }
            else
            {
                DeselectButton(button);
            }
        }
    }

    void SelectButton(Button button)
    {
        var colors = button.colors;
        colors.normalColor = Color.cyan;
        colors.highlightedColor = new Color32(100, 150, 255, 255);
        button.colors = colors;
    }

    void DeselectButton(Button button)
    {
        var colors = button.colors;
        colors.normalColor = Color.white;
        colors.highlightedColor = button.colors.pressedColor;
        button.colors = colors;
    }

    void SliderChanged()
    {
        AudioListener.volume = volumeSlider.value / 100;
        Debug.Log("Slider Value: " + volumeSlider.value);
    }

    void UpdateEnvironment()
    {
        springAndSummerTerrain.SetActive(false);
        autumnTerrain.SetActive(false);
        winterTerrainAndObjects.SetActive(false);
        snowEffect.SetActive(false);

        switch (selectedSeason)
        {
            case "Summer": case "Spring":
                springAndSummerTerrain.SetActive(true);
                break;
            case "Autumn":
                autumnTerrain.SetActive(true);
                break;
            case "Winter":
                winterTerrainAndObjects.SetActive(true);
                if (selectedWeather == "Snowy")
                {
                    snowEffect.SetActive(true);
                }
                break;
        }

        if (selectedWeather == "Rainy")
        {
            if (currentRainEffect == null)
            {
                currentRainEffect = Instantiate(rainEffect);
            }
        }
        else
        {
            if (currentRainEffect != null)
            {
                Destroy(currentRainEffect);
                currentRainEffect = null;
            }
        }
 
        Material skyMaterial = daySunnySky;

        if (selectedTimeOfDay == "Day")
        {
            if (selectedWeather == "Sunny")
            {
                skyMaterial = daySunnySky;
            }
            else if (selectedWeather == "Rainy" || selectedWeather == "Snowy")
            {
                skyMaterial = rainSnowDaySky;
            }
        }
        else if (selectedTimeOfDay == "Night")
        {
            if (selectedWeather == "Sunny")
            {
                skyMaterial = nightSunnySky;
            }
            else if (selectedWeather == "Rainy" || selectedWeather == "Snowy")
            {
                skyMaterial = rainSnowNightSky;
            }
        }

        RenderSettings.skybox = skyMaterial;
        DynamicGI.UpdateEnvironment();

        Debug.Log($"Environment updated: Season: {selectedSeason}, Weather: {selectedWeather}, Time of Day: {selectedTimeOfDay}");
    }
}
