using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Overlay_Player : MonoBehaviour
{
    /* This script is only for Player Menu to pull up Inventory, Stats, Skills, Controls
     * Work Load - Pei Sheng
     */

    //Player Display Panels
    [SerializeField]
    GameObject InventoryWindow;
    [SerializeField]
    GameObject StatsWindow;
    [SerializeField]
    GameObject SkillsWindow;
    [SerializeField]
    GameObject ControlsWindow;

    //Boolean for Buttton
    bool b_InventoryOpen;
    bool b_StatsOpen;
    bool b_SkillsOpen;
    bool b_ControlsOpen;

    // Use this for initialization
    void Start () {
        b_InventoryOpen = true;
        b_StatsOpen = false;
        b_SkillsOpen = false;
        b_ControlsOpen = false;
    }
	
	// Update is called once per frame
	void Update () {
        InventoryWindow.SetActive(b_InventoryOpen);
        StatsWindow.SetActive(b_StatsOpen);
        SkillsWindow.SetActive(b_SkillsOpen);
        ControlsWindow.SetActive(b_ControlsOpen);
    }

    //Button Control
    public void InventoryWindow_Open()
    {
        Debug.Log("Inventory opened");
        b_InventoryOpen = true;
        b_StatsOpen = false;
        b_SkillsOpen = false;
        b_ControlsOpen = false;
    }

    public void StatsWindow_Open()
    {
        Debug.Log("Stats opened");
        b_InventoryOpen = false;
        b_StatsOpen = true;
        b_SkillsOpen = false;
        b_ControlsOpen = false;
    }

    public void SkillsWindow_Open()
    {
        Debug.Log("Skills opened");
        b_InventoryOpen = false;
        b_StatsOpen = false;
        b_SkillsOpen = true;
        b_ControlsOpen = false;
    }

    public void ControlsWindow_Open()
    {
        Debug.Log("Controls opened");
        b_InventoryOpen = false;
        b_StatsOpen = false;
        b_SkillsOpen = false;
        b_ControlsOpen = true;
    }
}
