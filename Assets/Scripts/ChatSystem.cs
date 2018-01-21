using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatSystem : MonoBehaviour {

    public GameObject InputBox;
    public GameObject Scroll;
    public GameObject TextBox;

    string Name;

    // Use this for initialization
    void Start()
    {
        Name = "Player1: ";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UploadMessage()
    {
        if (InputBox.GetComponent<InputField>().text == "")
            return;

        TextBox.GetComponent<Text>().text += Name + InputBox.GetComponent<InputField>().text + "\n";
        InputBox.GetComponent<InputField>().text = "";

        Scroll.GetComponent<Scrollbar>().value = 0;
    }
}
