using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Overlay_Communications : MonoBehaviour {
    [SerializeField]
    GameObject Buddy;
    [SerializeField]
    GameObject BuddyButton;

    [SerializeField]
    GameObject Party;
    [SerializeField]
    GameObject PartyButton;

    [SerializeField]
    GameObject Guild;
    [SerializeField]
    GameObject GuildButton;

    [SerializeField]
    GameObject BuddyOnline;
    [SerializeField]
    GameObject BuddyOffline;
    [SerializeField]
    GameObject GuildOnline;
    [SerializeField]
    GameObject GuildOffline;

    [SerializeField]
    Dropdown BuddyStatus;
    [SerializeField]
    Dropdown GuildStatus;

    [SerializeField]
    GameObject BuddyAdd;
    [SerializeField]
    GameObject GuildAdd;

    bool b_buddyOpen;
    bool b_partyOpen;
    bool b_guildOpen;

    bool b_buddyonlineOpen;
    bool b_buddyofflineOpen;
    bool b_guildonlineOpen;
    bool b_guildofflineOpen;

    bool b_buddyaddOpen;
    bool b_guildaddOpen;

    public Color ButtonActiveColour = Color.red;
    public Color ButtonInactiveColour = Color.cyan;

    // Use this for initialization
    void Start ()
    {
        b_buddyOpen = true;
        b_partyOpen = false;
        b_guildOpen = false;

        b_buddyonlineOpen = true;
        b_buddyofflineOpen = false;
        b_guildonlineOpen = true;
        b_guildofflineOpen = false;
        b_buddyaddOpen = false;
        b_guildaddOpen = false;

        BuddyButton.GetComponent<Image>().color = ButtonActiveColour;
        PartyButton.GetComponent<Image>().color = ButtonInactiveColour;
        GuildButton.GetComponent<Image>().color = ButtonInactiveColour;
    }
	
	// Update is called once per frame
	void Update ()
    {
        Buddy.SetActive(b_buddyOpen);
        Party.SetActive(b_partyOpen);
        Guild.SetActive(b_guildOpen);
        BuddyOnline.SetActive(b_buddyonlineOpen);
        BuddyOffline.SetActive(b_buddyofflineOpen);
        GuildOnline.SetActive(b_guildonlineOpen);
        GuildOffline.SetActive(b_guildofflineOpen);

        BuddyAdd.SetActive(b_buddyaddOpen);
        GuildAdd.SetActive(b_guildaddOpen);

        if (b_buddyOpen)
            BuddyButton.GetComponent<Image>().color = ButtonActiveColour;
        else
            BuddyButton.GetComponent<Image>().color = ButtonInactiveColour;

        if (b_partyOpen)
            PartyButton.GetComponent<Image>().color = ButtonActiveColour;
        else
            PartyButton.GetComponent<Image>().color = ButtonInactiveColour;

        if (b_guildOpen)
            GuildButton.GetComponent<Image>().color = ButtonActiveColour;
        else
            GuildButton.GetComponent<Image>().color = ButtonInactiveColour;
    }

    public void ChangeGuildPanel()
    {
        int CurrentlySelectedValue = GuildStatus.value;
        if (CurrentlySelectedValue == 0)
        {
            GuildOffline_Close();
            GuildOnline_Open();
        }
        else if (CurrentlySelectedValue == 1)
        {
            GuildOnline_Close();
            GuildOffline_Open();
        }
    }
    public void ChangeBuddyPanel()
    {
        int CurrentlySelectedValue = BuddyStatus.value;
        if (CurrentlySelectedValue == 0)
        {
            BuddyOffline_Close();
            BuddyOnline_Open();
        }
        else if (CurrentlySelectedValue == 1)
        {
            BuddyOnline_Close();
            BuddyOffline_Open();
        }
    }
    //Buddy
    public void Buddy_Open()
    {
        Debug.Log("Buddy_Opened");
        b_buddyOpen = true;
        b_partyOpen = false;
        b_guildOpen = false;

        b_buddyonlineOpen = true;
    }
    public void Buddy_Close()
    {
        Debug.Log("Buddy_Closed");
        b_buddyOpen = false;
    }

    //Party
    public void Party_Open()
    {
        Debug.Log("Party_Opened");
        b_partyOpen = true;
        b_buddyOpen = false;
        b_guildOpen = false;
    }
    public void Party_Close()
    {
        Debug.Log("Party_Closed");
        b_partyOpen = false;
    }

    //Guild
    public void Guild_Open()
    {
        Debug.Log("Guild_Opened");
        b_guildOpen = true;
        b_buddyOpen = false;
        b_partyOpen = false;

        b_guildonlineOpen = true;
    }
    public void Guild_Close()
    {
        Debug.Log("Guild_Closed");
        b_guildOpen = false;
    }

    //BuddyOnline
    public void BuddyOnline_Open()
    {
        Debug.Log("BuddyOnline_Opened");
        b_buddyonlineOpen = true;
    }
    public void BuddyOnline_Close()
    {
        Debug.Log("BuddyOnline_Closed");
        b_buddyonlineOpen = false;
    }

    //BuddyOffline
    public void BuddyOffline_Open()
    {
        Debug.Log("BuddyOffline_Opened");
        b_buddyofflineOpen = true;
    }
    public void BuddyOffline_Close()
    {
        Debug.Log("BuddyOffline_Closed");
        b_buddyofflineOpen = false;
    }

    //GuildOffline
    public void GuildOffline_Open()
    {
        Debug.Log("GuildOffline_Opened");
        b_guildofflineOpen = true;
    }
    public void GuildOffline_Close()
    {
        Debug.Log("GuildOffline_Closed");
        b_guildofflineOpen = false;
    }

    //GuildOnline
    public void GuildOnline_Open()
    {
        Debug.Log("GuildOnline_Opened");
        b_guildonlineOpen = true;
    }
    public void GuildOnline_Close()
    {
        Debug.Log("GuildOnline_Closed");
        b_guildonlineOpen = false;
    }

    //BuddyAdd
    public void BuddyAdd_Open()
    {
        Debug.Log("BuddyAdd_Opened");
        b_buddyaddOpen = true;
    }
    public void BuddyAdd_Close()
    {
        Debug.Log("BuddyAdd_Closed");
        b_buddyaddOpen = false;
    }

    //GuildAdd
    public void GuildAdd_Open()
    {
        Debug.Log("GuildAdd_Opened");
        b_guildaddOpen = true;
    }
    public void GuildAdd_Close()
    {
        Debug.Log("GuildAdd_Closed");
        b_guildaddOpen = false;
    }
}
