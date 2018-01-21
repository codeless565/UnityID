using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest : MonoBehaviour {
    [SerializeField]
    GameObject quest;

    // Use this for initialization
    void Start()
    {
        quest.GetComponent<Text>().text = "Save the village \n" +
            "\t\t\t Kill 100 Goblins " +
            "\t\t\t\t\t\t\t\t\t\t\t  Exp 200 Gold 500";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnQuestClick()
    {
        quest.GetComponent<Text>().text = "Save the village \n" +
            "\t\t\t Find Anna " +
            "\t\t\t\t\t\t\t\t\t\t\t\t\t Exp 50 Gold 100";
    }
}
