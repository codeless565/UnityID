using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Overlay_Player : MonoBehaviour
{
    /* This script is only for Player Menu to pull up Inventory, Profile, Skills, Loadout
     * Work Load - Pei Sheng
     */

    //Player Display Panels
    public GameObject InventoryWindow;
    public GameObject ProfileWindow;
    public GameObject SkillsWindow;
    public GameObject LoadoutWindow;
    public GameObject LoadoutSkillWindow;
    public GameObject LoadoutItemWindow;

    //Buttons
    public GameObject InventoryButton;
    public GameObject ProfileButton;
    public GameObject SkillsButton;
    public GameObject LoadoutButton;

    Color ActiveTab = Color.red;
    Color InactiveTab = Color.cyan;

    // Use this for initialization
    void Start ()
    {
        InventoryWindow_Open();
    }

    // Update is called once per frame
    void Update () {
    }

    //Button Control
    public void InventoryWindow_Open()
    {
        InventoryWindow.SetActive(true);
        ProfileWindow.SetActive(false);
        SkillsWindow.SetActive(false);
        LoadoutWindow.SetActive(false);

        InventoryButton.GetComponent<Image>().color = ActiveTab;
        ProfileButton.GetComponent<Image>().color = InactiveTab;
        SkillsButton.GetComponent<Image>().color = InactiveTab;
        LoadoutButton.GetComponent<Image>().color = InactiveTab;

        LoadoutSkill_Open();
    }

    public void ProfileWindow_Open()
    {
        InventoryWindow.SetActive(false);
        ProfileWindow.SetActive(true);
        SkillsWindow.SetActive(false);
        LoadoutWindow.SetActive(false);

        InventoryButton.GetComponent<Image>().color = InactiveTab;
        ProfileButton.GetComponent<Image>().color = ActiveTab;
        SkillsButton.GetComponent<Image>().color = InactiveTab;
        LoadoutButton.GetComponent<Image>().color = InactiveTab;

        LoadoutSkill_Open();
    }

    public void SkillsWindow_Open()
    {
        InventoryWindow.SetActive(false);
        ProfileWindow.SetActive(false);
        SkillsWindow.SetActive(true);
        LoadoutWindow.SetActive(false);

        InventoryButton.GetComponent<Image>().color = InactiveTab;
        ProfileButton.GetComponent<Image>().color = InactiveTab;
        SkillsButton.GetComponent<Image>().color = ActiveTab;
        LoadoutButton.GetComponent<Image>().color = InactiveTab;

        LoadoutSkill_Open();
    }

    public void LoadoutWindow_Open()
    {
        InventoryWindow.SetActive(false);
        ProfileWindow.SetActive(false);
        SkillsWindow.SetActive(false);
        LoadoutWindow.SetActive(true);

        InventoryButton.GetComponent<Image>().color = InactiveTab;
        ProfileButton.GetComponent<Image>().color = InactiveTab;
        SkillsButton.GetComponent<Image>().color = InactiveTab;
        LoadoutButton.GetComponent<Image>().color = ActiveTab;

        LoadoutSkill_Open();
    }

    public void LoadoutSkill_Open()
    {
        LoadoutSkillWindow.SetActive(true);
        LoadoutItemWindow.SetActive(false);
    }

    public void LoadoutItem_Open()
    {
        LoadoutSkillWindow.SetActive(false);
        LoadoutItemWindow.SetActive(true);
    }
}
