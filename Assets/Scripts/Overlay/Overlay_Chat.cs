using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Overlay_Chat : MonoBehaviour
{
    /* This script is only for Chat Overlay to pull up World chat, Proximity chat, Guild Chat, Party Chat, Sytem Announcement
     * Work Load - Pei Sheng
     */

    //Tab
    public GameObject WorldTab;
    public GameObject ProximityTab;
    public GameObject GuildTab;
    public GameObject PartyTab;
    public GameObject SystemTab;

    //Button
    public GameObject WorldButton;
    public GameObject ProximityButton;
    public GameObject GuildButton;
    public GameObject PartyButton;
    public GameObject SystemButton;

    Color ActiveTab = Color.red;
    Color InactiveTab = Color.cyan;

    // Use this for initialization
    void Start () {
        WorldTab_Open();
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void WorldTab_Open()
    {
        WorldTab.SetActive(true);
        ProximityTab.SetActive(false);
        GuildTab.SetActive(false);
        PartyTab.SetActive(false);
        SystemTab.SetActive(false);

        WorldButton.GetComponent<Image>().color = ActiveTab;
        ProximityButton.GetComponent<Image>().color = InactiveTab;
        GuildButton.GetComponent<Image>().color = InactiveTab;
        PartyButton.GetComponent<Image>().color = InactiveTab;
        SystemButton.GetComponent<Image>().color = InactiveTab;
    }

    public void ProximityTab_Open()
    {
        WorldTab.SetActive(false);
        ProximityTab.SetActive(true);
        GuildTab.SetActive(false);
        PartyTab.SetActive(false);
        SystemTab.SetActive(false);

        WorldButton.GetComponent<Image>().color = InactiveTab;
        ProximityButton.GetComponent<Image>().color = ActiveTab;
        GuildButton.GetComponent<Image>().color = InactiveTab;
        PartyButton.GetComponent<Image>().color = InactiveTab;
        SystemButton.GetComponent<Image>().color = InactiveTab;
    }

    public void GuildTab_Open()
    {
        WorldTab.SetActive(false);
        ProximityTab.SetActive(false);
        GuildTab.SetActive(true);
        PartyTab.SetActive(false);
        SystemTab.SetActive(false);

        WorldButton.GetComponent<Image>().color = InactiveTab;
        ProximityButton.GetComponent<Image>().color = InactiveTab;
        GuildButton.GetComponent<Image>().color = ActiveTab;
        PartyButton.GetComponent<Image>().color = InactiveTab;
        SystemButton.GetComponent<Image>().color = InactiveTab;
    }

    public void PartyTab_Open()
    {
        WorldTab.SetActive(false);
        ProximityTab.SetActive(false);
        GuildTab.SetActive(false);
        PartyTab.SetActive(true);
        SystemTab.SetActive(false);

        WorldButton.GetComponent<Image>().color = InactiveTab;
        ProximityButton.GetComponent<Image>().color = InactiveTab;
        GuildButton.GetComponent<Image>().color = InactiveTab;
        PartyButton.GetComponent<Image>().color = ActiveTab;
        SystemButton.GetComponent<Image>().color = InactiveTab;
    }

    public void SystemTab_Open()
    {
        WorldTab.SetActive(false);
        ProximityTab.SetActive(false);
        GuildTab.SetActive(false);
        PartyTab.SetActive(false);
        SystemTab.SetActive(true);

        WorldButton.GetComponent<Image>().color = InactiveTab;
        ProximityButton.GetComponent<Image>().color = InactiveTab;
        GuildButton.GetComponent<Image>().color = InactiveTab;
        PartyButton.GetComponent<Image>().color = InactiveTab;
        SystemButton.GetComponent<Image>().color = ActiveTab;
    }
}
