using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour {

    [SerializeField]
    public Text printout;

	// Use this for initialization
	void Start () {
        printout.text = "Started";

    }

    // Update is called once per frame
    void Update () {
	}

    public void ClickButtA()
    {
        printout.text = "Button A pressed!";
    }

    public void ClickButtB()
    {
        printout.text = "Button B pressed!";
    }
}
