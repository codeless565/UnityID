using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverlayManager : MonoBehaviour
{
    /* This Script is only for Game Screen to pull up other overlays and Tabs
     * Comment any changes made with //CHANGE-start and //CHANGE-end codes
     * Work Load - Pei Sheng
     */

    //Set Canvas of each overlay
    [SerializeField]
    GameObject Map;
    [SerializeField]
    GameObject Player;
    [SerializeField]
    GameObject Chat;
    [SerializeField]
    GameObject ExtendMenu;
    [SerializeField]
    GameObject ExtendButton;
    [SerializeField]
    GameObject Quest;
    [SerializeField]
    GameObject Community;
    [SerializeField]
    GameObject Shop;
    [SerializeField]
    GameObject Setting;

	// Use this for initialization
	void Start () {
        Map.SetActive(false);
        Player.SetActive(false);
        Chat.SetActive(false);

        //Extended Menu
        ExtendMenu.SetActive(false);
        ExtendButton.SetActive(true);

        Shop.SetActive(false);
        Community.SetActive(false);
        Quest.SetActive(false);
        Setting.SetActive(false);

    }

    // Update is called once per frame
    void Update () {
    }

    //Map Overlay
    public void Map_Open()
    {
        Map.SetActive(true);
        Player.SetActive(false);
        Chat.SetActive(false);

        //Extended Menu
        ExtendMenu.SetActive(false);
        ExtendButton.SetActive(false);

        Shop.SetActive(false);
        Community.SetActive(false);
        Quest.SetActive(false);
        Setting.SetActive(false);
    }
    public void Map_Close()
    {
        Map.SetActive(false);
        ExtendButton.SetActive(true);
    }

    //Player Overlay
    public void Player_Open()
    {
        Map.SetActive(false);
        Player.SetActive(true);
        Chat.SetActive(false);

        //Extended Menu
        ExtendMenu.SetActive(false);
        ExtendButton.SetActive(false);

        Shop.SetActive(false);
        Community.SetActive(false);
        Quest.SetActive(false);
        Setting.SetActive(false);
    }
    public void Player_Close()
    {
        Player.SetActive(false);
        ExtendButton.SetActive(true);
    }

    //Chat Overlay
    public void Chat_Toggle()
    {
        if (!Chat.activeSelf)
        {
            Map.SetActive(false);
            Player.SetActive(false);
            Chat.SetActive(true);

            //Extended Menu
            ExtendMenu.SetActive(false);
            ExtendButton.SetActive(false);

            Shop.SetActive(false);
            Community.SetActive(false);
            Quest.SetActive(false);
            Setting.SetActive(false);
        }
        else
        {
            Chat.SetActive(false);
        }
    }

    //Extended Menu
    public void ExtendedMenu_Open()
    {
        ExtendMenu.SetActive(true);
        ExtendButton.SetActive(false);
    }
    public void ExtendedMenu_Close()
    {
        ExtendMenu.SetActive(false);
        ExtendButton.SetActive(true);
    }

    //Cash Shop
    public void Shop_Open()
    {
        Map.SetActive(false);
        Player.SetActive(false);
        Chat.SetActive(false);

        //Extended Menu
        ExtendMenu.SetActive(false);
        ExtendButton.SetActive(false);

        Shop.SetActive(true);
        Community.SetActive(false);
        Quest.SetActive(false);
        Setting.SetActive(false);
    }
    public void Shop_Close()
    {
        Shop.SetActive(false);
        ExtendButton.SetActive(true);
    }

    //Community
    public void Community_Open()
    {
        Map.SetActive(false);
        Player.SetActive(false);
        Chat.SetActive(false);

        //Extended Menu
        ExtendMenu.SetActive(false);
        ExtendButton.SetActive(false);

        Shop.SetActive(false);
        Community.SetActive(true);
        Quest.SetActive(false);
        Setting.SetActive(false);
    }
    public void Community_Close()
    {
        Community.SetActive(false);
        ExtendButton.SetActive(true);
    }

    //Quest
    public void Quest_Open()
    {
        Map.SetActive(false);
        Player.SetActive(false);
        Chat.SetActive(false);

        //Extended Menu
        ExtendMenu.SetActive(false);
        ExtendButton.SetActive(false);

        Shop.SetActive(false);
        Community.SetActive(false);
        Quest.SetActive(true);
        Setting.SetActive(false);
    }
    public void Quest_Close()
    {
        Quest.SetActive(false);
        ExtendButton.SetActive(true);
    }

    //Setting
    public void Setting_Open()
    {
        Map.SetActive(false);
        Player.SetActive(false);
        Chat.SetActive(false);

        //Extended Menu
        ExtendMenu.SetActive(false);
        ExtendButton.SetActive(false);

        Shop.SetActive(false);
        Community.SetActive(false);
        Quest.SetActive(false);
        Setting.SetActive(true);
    }
    public void Setting_Close()
    {
        Setting.SetActive(false);
        ExtendButton.SetActive(true);
    }
}
