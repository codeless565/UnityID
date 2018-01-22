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
    public GameObject InventoryMainWindow;
    public GameObject InventoryEquipmentWindow;
    public GameObject InventoryUseWindow;
    public GameObject InventoryMaterialWindow;
    public GameObject ProfileWindow;
    public GameObject SkillsWindow;
    public GameObject LoadoutWindow;
    public GameObject LoadoutSkillWindow;
    public GameObject LoadoutItemWindow;

    //Buttons
    public GameObject InventoryButton;
    public GameObject InventoryEquipmentButton;
    public GameObject InventoryUseButton;
    public GameObject InventoryMaterialButton;
    public GameObject ProfileButton;
    public GameObject SkillsButton;
    public GameObject LoadoutButton;

    Color ActiveTab = Color.red;
    Color InactiveTab = Color.cyan;

    // Use this for initialization
    void Start ()
    {
        InventoryMainWindow_Open();
        InventoryEquipmentWindow_Open();
    }

    // Update is called once per frame
    void Update () {
    }

    //Button Control
    //Inventory
    public void InventoryMainWindow_Open()
    {
        InventoryMainWindow.SetActive(true);
        ProfileWindow.SetActive(false);
        SkillsWindow.SetActive(false);
        LoadoutWindow.SetActive(false);

        InventoryButton.GetComponent<Image>().color = ActiveTab;
        ProfileButton.GetComponent<Image>().color = InactiveTab;
        SkillsButton.GetComponent<Image>().color = InactiveTab;
        LoadoutButton.GetComponent<Image>().color = InactiveTab;

        LoadoutSkill_Open();
    }

    public void InventoryEquipmentWindow_Open()
    {
        InventoryEquipmentWindow.SetActive(true);
        InventoryUseWindow.SetActive(false);
        InventoryMaterialWindow.SetActive(false);

        InventoryEquipmentButton.GetComponent<Image>().color = ActiveTab;
        InventoryUseButton.GetComponent<Image>().color = InactiveTab;
        InventoryMaterialButton.GetComponent<Image>().color = InactiveTab;
    }

    public void InventoryUseWindow_Open()
    {
        InventoryEquipmentWindow.SetActive(false);
        InventoryUseWindow.SetActive(true);
        InventoryMaterialWindow.SetActive(false);

        InventoryEquipmentButton.GetComponent<Image>().color = InactiveTab;
        InventoryUseButton.GetComponent<Image>().color = ActiveTab;
        InventoryMaterialButton.GetComponent<Image>().color = InactiveTab;
    }

    public void InventoryMaterialWindow_Open()
    {
        InventoryEquipmentWindow.SetActive(false);
        InventoryUseWindow.SetActive(false);
        InventoryMaterialWindow.SetActive(true);

        InventoryEquipmentButton.GetComponent<Image>().color = InactiveTab;
        InventoryUseButton.GetComponent<Image>().color = InactiveTab;
        InventoryMaterialButton.GetComponent<Image>().color = ActiveTab;
    }

    public void ProfileWindow_Open()
    {
        InventoryMainWindow.SetActive(false);
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
        InventoryMainWindow.SetActive(false);
        ProfileWindow.SetActive(false);
        SkillsWindow.SetActive(true);
        LoadoutWindow.SetActive(false);

        InventoryButton.GetComponent<Image>().color = InactiveTab;
        ProfileButton.GetComponent<Image>().color = InactiveTab;
        SkillsButton.GetComponent<Image>().color = ActiveTab;
        LoadoutButton.GetComponent<Image>().color = InactiveTab;

        LoadoutSkill_Open();
    }

    //Loadout
    public void LoadoutWindow_Open()
    {
        InventoryMainWindow.SetActive(false);
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
