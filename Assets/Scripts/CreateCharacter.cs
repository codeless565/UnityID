using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateCharacter : MonoBehaviour {

    [SerializeField]
    GameObject ConfirmedGender;
    [SerializeField]
    GameObject ConfirmedNose;
    [SerializeField]
    GameObject ConfirmedEyes;
    [SerializeField]
    GameObject ConfirmedMouth;
    
    string ConfirmedName;

    // Gender
    [SerializeField]
    GameObject GenderOne;
    [SerializeField]
    GameObject GenderTwo;

    // Nose
    [SerializeField]
    GameObject NoseOne;
    [SerializeField]
    GameObject NoseTwo;
    [SerializeField]
    GameObject NoseThree;
    [SerializeField]
    GameObject NoseFour;

    // Eyes
    [SerializeField]
    GameObject EyesOne;
    [SerializeField]
    GameObject EyesTwo;
    [SerializeField]
    GameObject EyesThree;
    [SerializeField]
    GameObject EyesFour;

    // Mouths
    [SerializeField]
    GameObject MouthOne;
    [SerializeField]
    GameObject MouthTwo;
    [SerializeField]
    GameObject MouthThree;
    [SerializeField]
    GameObject MouthFour;

    [SerializeField]
    GameObject Name;

    [SerializeField]
    GameObject GenderOneButton;
    [SerializeField]
    GameObject GenderTwoButton;

    [SerializeField]
    GameObject NoseOneButton;
    [SerializeField]
    GameObject NoseTwoButton;
    [SerializeField]
    GameObject NoseThreeButton;
    [SerializeField]
    GameObject NoseFourButton;

    [SerializeField]
    GameObject EyesOneButton;
    [SerializeField]
    GameObject EyesTwoButton;
    [SerializeField]
    GameObject EyesThreeButton;
    [SerializeField]
    GameObject EyesFourButton;

    [SerializeField]
    GameObject MouthOneButton;
    [SerializeField]
    GameObject MouthTwoButton;
    [SerializeField]
    GameObject MouthThreeButton;
    [SerializeField]
    GameObject MouthFourButton;

    public Color ButtonActiveColour = Color.red;
    public Color ButtonInactiveColour = Color.cyan;


    // Use this for initialization
    void Start () {
        SelectedGender1();
         SelectedEyes1();
        SelectedNose1();
        SelectedMouth1();
   }
	
	// Update is called once per frame
	void Update () {
    }

    public void NameUpdate()
    {
        ConfirmedName = Name.GetComponent<InputField>().text;
    }

    void ResetGenderColours()
    {
        GenderOneButton.GetComponent<Image>().color = ButtonInactiveColour;
        GenderTwoButton.GetComponent<Image>().color = ButtonInactiveColour;
    }

    void ResetNoseColours()
    {
        NoseOneButton.GetComponent<Image>().color = ButtonInactiveColour;
        NoseTwoButton.GetComponent<Image>().color = ButtonInactiveColour;
        NoseThreeButton.GetComponent<Image>().color = ButtonInactiveColour;
        NoseFourButton.GetComponent<Image>().color = ButtonInactiveColour;
    }

    void ResetEyesColours()
    {
        EyesOneButton.GetComponent<Image>().color = ButtonInactiveColour;
        EyesTwoButton.GetComponent<Image>().color = ButtonInactiveColour;
        EyesThreeButton.GetComponent<Image>().color = ButtonInactiveColour;
        EyesFourButton.GetComponent<Image>().color = ButtonInactiveColour;
    }

    void ResetMouthColours()
    {
        MouthOneButton.GetComponent<Image>().color = ButtonInactiveColour;
        MouthTwoButton.GetComponent<Image>().color = ButtonInactiveColour;
        MouthThreeButton.GetComponent<Image>().color = ButtonInactiveColour;
        MouthFourButton.GetComponent<Image>().color = ButtonInactiveColour;
    }

    // Gender
    public void SelectedGender1()
    {
        ResetGenderColours();
        GenderOneButton.GetComponent<Image>().color = ButtonActiveColour;
        ConfirmedGender.GetComponent<Image>().sprite = GenderOne.GetComponent<Image>().sprite;
    }
    public void SelectedGender2()
    {
        ResetGenderColours();
        GenderTwoButton.GetComponent<Image>().color = ButtonActiveColour;
        ConfirmedGender.GetComponent<Image>().sprite = GenderTwo.GetComponent<Image>().sprite;
    }

    // Nose
    public void SelectedNose1()
    {
        ResetNoseColours();
        NoseOneButton.GetComponent<Image>().color = ButtonActiveColour;
        ConfirmedNose.GetComponent<Image>().sprite = NoseOne.GetComponent<Image>().sprite;
    }
    public void SelectedNose2()
    {
        ResetNoseColours();
        NoseTwoButton.GetComponent<Image>().color = ButtonActiveColour;
        ConfirmedNose.GetComponent<Image>().sprite = NoseTwo.GetComponent<Image>().sprite;
    }
    public void SelectedNose3()
    {
        ResetNoseColours();
        NoseThreeButton.GetComponent<Image>().color = ButtonActiveColour;
        ConfirmedNose.GetComponent<Image>().sprite = NoseThree.GetComponent<Image>().sprite;
    }
    public void SelectedNose4()
    {
        ResetNoseColours();
        NoseFourButton.GetComponent<Image>().color = ButtonActiveColour;
        ConfirmedNose.GetComponent<Image>().sprite = NoseFour.GetComponent<Image>().sprite;
    }

    // Eyes
    public void SelectedEyes1()
    {
        ResetEyesColours();
        EyesOneButton.GetComponent<Image>().color = ButtonActiveColour;
        ConfirmedEyes.GetComponent<Image>().sprite = EyesOne.GetComponent<Image>().sprite;
    }
    public void SelectedEyes2()
    {
        ResetEyesColours();
        EyesTwoButton.GetComponent<Image>().color = ButtonActiveColour;
        ConfirmedEyes.GetComponent<Image>().sprite = EyesTwo.GetComponent<Image>().sprite;
    }
    public void SelectedEyes3()
    {
        ResetEyesColours();
        EyesThreeButton.GetComponent<Image>().color = ButtonActiveColour;
        ConfirmedEyes.GetComponent<Image>().sprite = EyesThree.GetComponent<Image>().sprite;
    }
    public void SelectedEyes4()
    {
        ResetEyesColours();
        EyesFourButton.GetComponent<Image>().color = ButtonActiveColour;
        ConfirmedEyes.GetComponent<Image>().sprite = EyesFour.GetComponent<Image>().sprite;
    }

    // Mouth
    public void SelectedMouth1()
    {
        ResetMouthColours();
        MouthOneButton.GetComponent<Image>().color = ButtonActiveColour;
        ConfirmedMouth.GetComponent<Image>().sprite = MouthOne.GetComponent<Image>().sprite;
    }
    public void SelectedMouth2()
    {
        ResetMouthColours();
        MouthTwoButton.GetComponent<Image>().color = ButtonActiveColour;
        ConfirmedMouth.GetComponent<Image>().sprite = MouthTwo.GetComponent<Image>().sprite;
    }
    public void SelectedMouth3()
    {
        ResetMouthColours();
        MouthThreeButton.GetComponent<Image>().color = ButtonActiveColour;
        ConfirmedMouth.GetComponent<Image>().sprite = MouthThree.GetComponent<Image>().sprite;
    }
    public void SelectedMouth4()
    {
        ResetMouthColours();
        MouthFourButton.GetComponent<Image>().color = ButtonActiveColour;
        ConfirmedMouth.GetComponent<Image>().sprite = MouthFour.GetComponent<Image>().sprite;
    }

}
