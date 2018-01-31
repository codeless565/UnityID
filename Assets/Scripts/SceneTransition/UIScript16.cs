using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]

public class UIScript16 : MonoBehaviour
{
    public GUISkin refSkin;
    float screenWidth;
    float screenHeight;

    string textField;
    string textArea;
    bool toogleBool;
    float hSlider;
    float vSlider;
    float hScrollBar;
    string[] textToolbar;
    int selectedToolbar;

    Rect windOne;
    Rect windTwo;
    // Use this for initialization
    void Start()
    {
        screenWidth = (float)Screen.width / 1024;
        screenHeight = (float)Screen.height / 768;

        textField = "";
        textArea = "";
        toogleBool = false;
        hSlider = 0;
        vSlider = 0;
        hScrollBar = 0;
        textToolbar = new string[5] { "text1", "text2", "text3", "text4", "text5" };
        selectedToolbar = 0;

        windOne = new Rect(300 * screenWidth, 500 * screenHeight, 200 * screenWidth, 200 * screenHeight);
        windTwo = new Rect(600 * screenWidth, 500 * screenHeight, 200 * screenWidth, 200 * screenHeight);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGUI()
    {

        GUI.skin = refSkin;

        // Rect             Params   (position.x, position.y, width , height);

        // Label is just text
        // Box is text with background
        // GUI.*UI Choice*  Params   (Rect, Text to display, style);
        // Returns nothing
        GUI.Label(new Rect(100 * screenWidth, 100 * screenHeight, 100 * screenWidth, 50 * screenHeight), "Ohyes", "testlabel");
        GUI.Box(new Rect(100 * screenWidth, 200 * screenHeight, 100 * screenWidth, 50 * screenHeight), "hahaha", "testbox");

        // Button is on click
        // RepeatButton is on hold
        // GUI.*UI Choice*  Params   (Rect, Text to display, style);
        // Returns boolean
        if (GUI.Button(new Rect(100 * screenWidth, 300 * screenHeight, 100 * screenWidth, 50 * screenHeight), "button", "GUIBtn"))
            Debug.Log("Button pressed");
        if (GUI.RepeatButton(new Rect(100 * screenWidth, 400 * screenHeight, 100 * screenWidth, 50 * screenHeight), "button", "GUIBtn"))
            Debug.Log("Repeat Button pressed");

        // TODO textField vs textArea
        // GUI.*UI Choice*  Params   (Rect, Text to display, style);
        // Returns string
        textField = GUI.TextField(new Rect(100 * screenWidth, 500 * screenHeight, 100 * screenWidth, 50 * screenHeight), textField);
        textArea = GUI.TextArea(new Rect(100 * screenWidth, 600 * screenHeight, 100 * screenWidth, 50 * screenHeight), textArea);

        // GUI.*UI Choice*  Params   (Rect, default boolean, Text to display, style);
        // Returns boolean
        toogleBool = GUI.Toggle(new Rect(100 * screenWidth, 700 * screenHeight, 100 * screenWidth, 50 * screenHeight), toogleBool, "Toggle");
        if (toogleBool)
            Debug.Log("Toggle pressed");

        // GUI.*UI Choice*  Params   (Rect, default value, left value, right value);
        // Returns float
        hSlider = GUI.HorizontalSlider(new Rect(300 * screenWidth, 100 * screenHeight, 100 * screenWidth, 50 * screenHeight), hSlider, -50, 50);
        vSlider = GUI.VerticalSlider(new Rect(250 * screenWidth, 100 * screenHeight, 100 * screenWidth, 50 * screenHeight), vSlider, -50, 50);

        // Scrollbar
        // TODO Vertical ScrollBar and Params and Returns
        hScrollBar = GUI.HorizontalScrollbar(new Rect(300 * screenWidth, 200 * screenHeight, 100 * screenWidth, 50 * screenHeight), hScrollBar, 1, -50, 50);

        // GUI.*UI Choice*  Params   (Rect, default selected value, values to choose from);
        // Returns int
        selectedToolbar = GUI.Toolbar(new Rect(300 * screenWidth, 300 * screenHeight, 200 * screenWidth, 50 * screenHeight), selectedToolbar, textToolbar);

        // GUI.*UI Choice*  Params   (Rect, default selected value, values to choose from, number of Selection in a row);
        // Returns int
        selectedToolbar = GUI.SelectionGrid(new Rect(300 * screenWidth, 400 * screenHeight, 200 * screenWidth, 200 * screenHeight), selectedToolbar, textToolbar, 2);

        // TODO Params and Returns
        windOne = GUI.Window(0, windOne, WindowFunc, "");
        windTwo = GUI.Window(1, windTwo, WindowFunc, "");

        // GUI.BeginGroup;
        // GUI.EndGroup;
    }

    void WindowFunc(int windID)
    {
        GUI.DragWindow();
        switch (windID)
        {
            case 0:
                GUI.Label(new Rect(0, 0, 100 * screenWidth, 50 * screenHeight), "Ohyes", "testlabel");
                break;
            case 1:
                GUI.Label(new Rect(0, 0, 100 * screenWidth, 50 * screenHeight), "Ohyesss", "testlabel");
                break;
        }
        
    }
}
