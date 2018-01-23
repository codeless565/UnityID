using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest : MonoBehaviour {
    [SerializeField]
    GameObject quest;

    [SerializeField]
    GameObject MainQuestButton;
    [SerializeField]
    GameObject RepeatableQuestButton;
    [SerializeField]
    GameObject EventQuestButton;

    [SerializeField]
    GameObject MainQuestTab;
    [SerializeField]
    GameObject RepeatableQuestTab;
    [SerializeField]
    GameObject EventQuestTab;

    bool b_mainquestopen;
    bool b_repeatablequestopen;
    bool b_eventquestopen;

    public Color ButtonActiveColour = Color.red;
    public Color ButtonInactiveColour = Color.cyan;

    // Use this for initialization
    void Start()
    {
        b_mainquestopen = true;
        b_repeatablequestopen = false;
        b_eventquestopen = false;


        quest.GetComponent<Text>().text = "Save the village \n" +
            "\t\t\t Kill 100 Goblins " +
            "\t\t\t\t\t\t\t\t\t\t\t  Exp 200 Gold 500";
    }

    // Update is called once per frame
    void Update()
    {
        MainQuestTab.SetActive(b_mainquestopen);
        RepeatableQuestTab.SetActive(b_repeatablequestopen);
        EventQuestTab.SetActive(b_eventquestopen);

        if (b_mainquestopen)
            MainQuestButton.GetComponent<Image>().color = ButtonActiveColour;
        else
            MainQuestButton.GetComponent<Image>().color = ButtonInactiveColour;

        if (b_repeatablequestopen)
            RepeatableQuestButton.GetComponent<Image>().color = ButtonActiveColour;
        else
            RepeatableQuestButton.GetComponent<Image>().color = ButtonInactiveColour;

        if (b_eventquestopen)
            EventQuestButton.GetComponent<Image>().color = ButtonActiveColour;
        else
            EventQuestButton.GetComponent<Image>().color = ButtonInactiveColour;
    }

    public void OnQuestClick()
    {
        if (b_mainquestopen)
        {
            quest.GetComponent<Text>().text =   "Save the village \n" +
                                                "\t\t\t Find Anna " +
                                                "\t\t\t\t\t\t\t\t\t\t\t\t\t Exp 50 Gold 100";
        }
    }

    //main
    public void main_Open()
    {
        Debug.Log("main_Opened");
        b_mainquestopen = true;
        b_repeatablequestopen = false;
        b_eventquestopen = false;
    }
    public void main_Close()
    {
        Debug.Log("main_Closed");
        b_mainquestopen = false;
    }

    //repeatable
    public void repeatable_Open()
    {
        Debug.Log("repeatable_Opened");
        b_mainquestopen = false;
        b_repeatablequestopen = true;
        b_eventquestopen = false;
    }
    public void repeatable_Close()
    {
        Debug.Log("repeatable_Closed");
        b_repeatablequestopen = false;
    }

    //event
    public void event_Open()
    {
        Debug.Log("event_Opened");
        b_mainquestopen = false;
        b_repeatablequestopen = false;
        b_eventquestopen = true;
    }
    public void event_Close()
    {
        Debug.Log("event_Closed");
        b_eventquestopen = false;
    }

}
