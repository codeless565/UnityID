using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class EditorScript : ScriptableWizard {
    [MenuItem("MyScripts/My PopUp")]

    static void CreateWizard()
    {
        ScriptableWizard.DisplayWizard<EditorScript>("My Window Header", "Button 1", "Button 2");
        // ScriptableWizard.DisplayWizard<WizardCreateLight>("Create Light", "Create", "Apply");
        // If you don't want to use the secondary button simply leave it out:
        // ScriptableWizard.DisplayWizard<WizardCreateLight>("Create Light", "Create");
    }

    void OnWizardCreate()
    {
        //Button 1
        // Window close
    }
    void OnWizardUpdate()
    {
       
    }

    // When the user presses the "Apply" button OnWizardOtherButton is called.
    void OnWizardOtherButton()
    {
        //Button 2
        // Window does not close 
    }

    void OnGUI()
    {
        GUI.Label(new Rect(0, 0, 100 , 50 ), "Ohyes");
    }
}
