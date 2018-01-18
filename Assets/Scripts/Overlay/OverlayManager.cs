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


    //Boolean for overlays
    bool b_mapOpen;
    bool b_playerOpen;
    bool b_extendedMenu;
    bool b_extendedButton;
    bool b_chatOpen;
    bool b_shopOpen;
    bool b_communityOpen;
    bool b_questOpen;
    bool b_settingOpen;


	// Use this for initialization
	void Start () {
        b_mapOpen = false;
        b_playerOpen = false;
        b_chatOpen = false;

        b_extendedMenu = false;
        b_extendedButton = true;
        b_shopOpen = false;
        b_communityOpen = false;
        b_questOpen = false;
        b_settingOpen = false;
 
    }

    // Update is called once per frame
    void Update () {
        Map.SetActive(b_mapOpen);
        Player.SetActive(b_playerOpen);
        Chat.SetActive(b_chatOpen);

        //Extended Menu
        ExtendMenu.SetActive(b_extendedMenu);
        ExtendButton.SetActive(b_extendedButton);

        Shop.SetActive(b_shopOpen);
        Community.SetActive(b_communityOpen);
        Quest.SetActive(b_questOpen);
        Setting.SetActive(b_settingOpen);
    }

    //Map Overlay
    public void Map_Open()
    {
        Debug.Log("Map_Opened");
        b_mapOpen = true;

        //close other opened overlays
        if (b_chatOpen)
            b_chatOpen = false;
        if (b_playerOpen)
            b_playerOpen = false;
    }
    public void Map_Close()
    {
        Debug.Log("Map_Closed");
        b_mapOpen = false;
    }

    //Player Overlay
    public void Player_Open()
    {
        Debug.Log("Player_Opened");
        b_playerOpen = true;
        if (b_chatOpen)
            b_chatOpen = false;
        if (b_mapOpen)
            b_mapOpen = false;
    }
    public void Player_Close()
    {
        Debug.Log("Player_Closed");
        b_playerOpen = false;
    }

    //Chat Overlay
    public void Chat_Toggle()
    {
        Debug.Log("Chat_Toggled");
        b_chatOpen = !b_chatOpen;
    }
    
    //Extended Menu
    public void ExtendedMenu_Open()
    {
        Debug.Log("ExtendedMenu_Opened");
        b_extendedMenu = true;
        b_extendedButton = false;
    }
    public void ExtendedMenu_Close()
    {
        Debug.Log("ExtendedMenu_Closed");
        b_extendedMenu = false;
        b_extendedButton = true;
    }

    //Cash Shop
    public void Shop_Open()
    {
        Debug.Log("Shop_Opened");
        b_shopOpen = true;
    }
    public void Shop_Close()
    {
        Debug.Log("Shop_Closed");
        b_shopOpen = false;
    }

    //Community
    public void Community_Open()
    {
        Debug.Log("Community_Opened");
        b_communityOpen = true;
    }
    public void Community_Close()
    {
        Debug.Log("Community_Closed");
        b_communityOpen = false;
    }

    //Quest
    public void Quest_Open()
    {
        Debug.Log("Quest_Opened");
        b_questOpen = true;
    }
    public void Quest_Close()
    {
        Debug.Log("Quest_Closed");
        b_questOpen = false;
    }

    //Setting
    public void Setting_Open()
    {
        Debug.Log("Setting_Opened");
        b_settingOpen = true;
    }
    public void Setting_Close()
    {
        Debug.Log("Setting_Closed");
        b_settingOpen = false;
    }
}
