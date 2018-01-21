using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Overlay_Map : MonoBehaviour
{
    /* This script is only for Map Overlay to pull up World map, Town Map, Dungeon map
     * Work Load - Pei Sheng
     */

    public GameObject WorldTab;
    public GameObject DungeonTab;
    public GameObject TownTab;

    public GameObject Town1Button;
    public GameObject Town2Button;
    public GameObject Town3Button;
    public GameObject Town4Button;
    public GameObject Town5Button;

    public GameObject TownDisplay;

    // Use this for initialization
    void Start () {
        //Tabs
        WorldTab.SetActive(false);
        DungeonTab.SetActive(false);
        TownTab.SetActive(false);

        TownDisplay.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void WorldTab_Open()
    {
        WorldTab.SetActive(true);
        DungeonTab.SetActive(false);
        TownTab.SetActive(false);
        TownDisplay.SetActive(false);
    }

    public void DungeonTab_Open()
    {
        WorldTab.SetActive(false);
        DungeonTab.SetActive(true);
        TownTab.SetActive(false);
        TownDisplay.SetActive(false);
    }

    public void TownTab_Open()
    {
        WorldTab.SetActive(false);
        DungeonTab.SetActive(false);
        TownTab.SetActive(true);
        TownDisplay.SetActive(false);
    }

    public void Town1_View()
    {
        TownDisplay.SetActive(true);
        TownDisplay.GetComponent<Image>().sprite = Town1Button.GetComponent<Image>().sprite;
    }

    public void Town2_View()
    {
        TownDisplay.SetActive(true);
        TownDisplay.GetComponent<Image>().sprite = Town2Button.GetComponent<Image>().sprite;
    }

    public void Town3_View()
    {
        TownDisplay.SetActive(true);
        TownDisplay.GetComponent<Image>().sprite = Town3Button.GetComponent<Image>().sprite;
    }

    public void Town4_View()
    {
        TownDisplay.SetActive(true);
        TownDisplay.GetComponent<Image>().sprite = Town4Button.GetComponent<Image>().sprite;
    }

    public void Town5_View()
    {
        TownDisplay.SetActive(true);
        TownDisplay.GetComponent<Image>().sprite = Town5Button.GetComponent<Image>().sprite;
    }

    public void TownDisplay_Close()
    {
        TownDisplay.SetActive(false);
        TownDisplay.GetComponent<Image>().sprite = null;
    }
}
