using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Overlay_Options : MonoBehaviour {
    // Options settings
    [SerializeField]
    GameObject VideoTab;
    [SerializeField]
    GameObject AudioTab;
    [SerializeField]
    GameObject ConfigsTab;

    [SerializeField]
    GameObject VideoButton;
    [SerializeField]
    GameObject AudioButton;
    [SerializeField]
    GameObject ConfigButton;

    bool b_videoOpen;
    bool b_audioOpen;
    bool b_configsOpen;

    public Color ButtonActiveColour = Color.red;
    public Color ButtonInactiveColour = Color.cyan;

    // Video settings - SPECIFIC
    [SerializeField]
    GameObject GraphicsSettings;
    [SerializeField]
    GameObject CharacterSettings;
    [SerializeField]
    GameObject EnvrionmentSettings;
    [SerializeField]
    GameObject Shadow;
    [SerializeField]
    GameObject Particles;

    // Audio settings - SPECIFIC
    [SerializeField]
    GameObject MasterSettings;
    [SerializeField]
    GameObject MusicSettings;
    [SerializeField]
    GameObject SoundSettings;

    [SerializeField]
    GameObject MasterText;
    [SerializeField]
    GameObject MusicText;
    [SerializeField]
    GameObject SoundText;

    // Use this for initialization
    void Start () {
        b_videoOpen = true;
        b_audioOpen = false;
        b_configsOpen = false;

        VideoButton.GetComponent<Image>().color = ButtonActiveColour;
        AudioButton.GetComponent<Image>().color = ButtonInactiveColour;
        ConfigButton.GetComponent<Image>().color = ButtonInactiveColour;

        MasterText.GetComponent<Text>().text = MasterSettings.GetComponent<Slider>().value.ToString();
        MusicText.GetComponent<Text>().text = MusicSettings.GetComponent<Slider>().value.ToString();
        SoundText.GetComponent<Text>().text = SoundSettings.GetComponent<Slider>().value.ToString();
    }
	
	// Update is called once per frame
	void Update () {
        VideoTab.SetActive(b_videoOpen);
        AudioTab.SetActive(b_audioOpen);
        ConfigsTab.SetActive(b_configsOpen);

        if (b_videoOpen)
            VideoButton.GetComponent<Image>().color = ButtonActiveColour;
        else
            VideoButton.GetComponent<Image>().color = ButtonInactiveColour;

        if (b_audioOpen)
            AudioButton.GetComponent<Image>().color = ButtonActiveColour;
        else
            AudioButton.GetComponent<Image>().color = ButtonInactiveColour;

        if (b_configsOpen)
            ConfigButton.GetComponent<Image>().color = ButtonActiveColour;
        else
            ConfigButton.GetComponent<Image>().color = ButtonInactiveColour;

        
        GraphicsSettingsChange();
        AudioSettingsChange();
    }

    public void DefaultSettings()
    {
        if (b_videoOpen)
        {
            GraphicsSettings.GetComponent<Slider>().value = GraphicsSettings.GetComponent<Slider>().maxValue;
            CharacterSettings.GetComponent<Slider>().value = CharacterSettings.GetComponent<Slider>().maxValue;
            EnvrionmentSettings.GetComponent<Slider>().value = EnvrionmentSettings.GetComponent<Slider>().maxValue;
            Shadow.GetComponent<Toggle>().isOn = true;
            Particles.GetComponent<Toggle>().isOn = true;
        }

        if (b_audioOpen)
        {
            MasterSettings.GetComponent<Slider>().value = 100;
            MusicSettings.GetComponent<Slider>().value = 100;
            SoundSettings.GetComponent<Slider>().value = 100;
        }
    }
    void AudioSettingsChange()
    {
        MasterText.GetComponent<Text>().text = MasterSettings.GetComponent<Slider>().value.ToString();
        MusicText.GetComponent<Text>().text = MusicSettings.GetComponent<Slider>().value.ToString();
        SoundText.GetComponent<Text>().text = SoundSettings.GetComponent<Slider>().value.ToString();
    }
    void GraphicsSettingsChange()
    {
        // Ultra
        if (GraphicsSettings.GetComponent<Slider>().value == GraphicsSettings.GetComponent<Slider>().maxValue)
        {
            CharacterSettings.GetComponent<Slider>().value = CharacterSettings.GetComponent<Slider>().maxValue;
            EnvrionmentSettings.GetComponent<Slider>().value = EnvrionmentSettings.GetComponent<Slider>().maxValue;
            Shadow.GetComponent<Toggle>().isOn = true;
            Particles.GetComponent<Toggle>().isOn = true;
        }

        // High
        if (GraphicsSettings.GetComponent<Slider>().value == 3)
        {
            CharacterSettings.GetComponent<Slider>().value = CharacterSettings.GetComponent<Slider>().maxValue;
            EnvrionmentSettings.GetComponent<Slider>().value = EnvrionmentSettings.GetComponent<Slider>().maxValue;
            Shadow.GetComponent<Toggle>().isOn = false;
            Particles.GetComponent<Toggle>().isOn = false;
        }

        // Medium
        if (GraphicsSettings.GetComponent<Slider>().value == 2)
        {
            CharacterSettings.GetComponent<Slider>().value = 1;
            EnvrionmentSettings.GetComponent<Slider>().value = 1;
            Shadow.GetComponent<Toggle>().isOn = false;
            Particles.GetComponent<Toggle>().isOn = false;
        }

        // Low
        if (GraphicsSettings.GetComponent<Slider>().value == 1)
        {
            CharacterSettings.GetComponent<Slider>().value = CharacterSettings.GetComponent<Slider>().minValue;
            EnvrionmentSettings.GetComponent<Slider>().value = EnvrionmentSettings.GetComponent<Slider>().minValue;
            Shadow.GetComponent<Toggle>().isOn = false;
            Particles.GetComponent<Toggle>().isOn = false;
        }

        CharacterSettings.GetComponent<Slider>().onValueChanged.AddListener(delegate { ChangeToCustom(); });
        EnvrionmentSettings.GetComponent<Slider>().onValueChanged.AddListener(delegate { ChangeToCustom(); });
        Shadow.GetComponent<Toggle>().onValueChanged.AddListener(delegate { ChangeToCustom(); });
        Particles.GetComponent<Toggle>().onValueChanged.AddListener(delegate { ChangeToCustom(); });
    }

    public void ChangeToCustom()
    {
        GraphicsSettings.GetComponent<Slider>().value = 0;
    }

    // Video
    public void Video_Open()
    {
        Debug.Log("Video_Opened");
        b_videoOpen = true;
        b_audioOpen = false;
        b_configsOpen = false;
    }
    public void Video_Close()
    {
        Debug.Log("Video_Closed");
        b_videoOpen = false;
    }

    // Audio
    public void Audio_Open()
    {
        Debug.Log("Audio_Opened");
        b_videoOpen = false;
        b_audioOpen = true;
        b_configsOpen = false;
    }
    public void Audio_Close()
    {
        Debug.Log("Audio_Closed");
        b_audioOpen = false;
    }

    // Configs
    public void Configs_Open()
    {
        Debug.Log("Configs_Opened");
        b_videoOpen = false;
        b_audioOpen = false;
        b_configsOpen = true;
    }
    public void Configs_Close()
    {
        Debug.Log("Configs_Closed");
        b_configsOpen = false;
    }
}