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

    bool selectedGender;
   bool selectedNose;
   bool selectedEyes;
   bool selectedMouth;

    // Use this for initialization
    void Start () {
        selectedGender = false;
        selectedNose = false;
        selectedEyes = false;
        selectedMouth = false;
	}
	
	// Update is called once per frame
	void Update () {
        ConfirmedGender.SetActive(selectedGender);
        ConfirmedNose.SetActive(selectedNose);
        ConfirmedEyes.SetActive(selectedEyes);
        ConfirmedMouth.SetActive(selectedMouth);
    }

    public void NameUpdate()
    {
        ConfirmedName = Name.GetComponent<InputField>().text;
    }

    // Gender
    public void SelectedGender1()
    {
        selectedGender = true;
        ConfirmedGender.GetComponent<Image>().sprite = GenderOne.GetComponent<Image>().sprite;
    }
    public void SelectedGender2()
    {
        selectedGender = true;
        ConfirmedGender.GetComponent<Image>().sprite = GenderTwo.GetComponent<Image>().sprite;
    }

    // Nose
    public void SelectedNose1()
    {
        selectedNose = true;
        ConfirmedNose.GetComponent<Image>().sprite = NoseOne.GetComponent<Image>().sprite;
    }
    public void SelectedNose2()
    {
        selectedNose = true;
        ConfirmedNose.GetComponent<Image>().sprite = NoseTwo.GetComponent<Image>().sprite;
    }
    public void SelectedNose3()
    {
        selectedNose = true;
        ConfirmedNose.GetComponent<Image>().sprite = NoseThree.GetComponent<Image>().sprite;
    }
    public void SelectedNose4()
    {
        selectedNose = true;
        ConfirmedNose.GetComponent<Image>().sprite = NoseFour.GetComponent<Image>().sprite;
    }

    // Eyes
    public void SelectedEyes1()
    {
        selectedEyes = true;
        ConfirmedEyes.GetComponent<Image>().sprite = EyesOne.GetComponent<Image>().sprite;
    }
    public void SelectedEyes2()
    {
        selectedEyes = true;
        ConfirmedEyes.GetComponent<Image>().sprite = EyesTwo.GetComponent<Image>().sprite;
    }
    public void SelectedEyes3()
    {
        selectedEyes = true;
        ConfirmedEyes.GetComponent<Image>().sprite = EyesThree.GetComponent<Image>().sprite;
    }
    public void SelectedEyes4()
    {
        selectedEyes = true;
        ConfirmedEyes.GetComponent<Image>().sprite = EyesFour.GetComponent<Image>().sprite;
    }

    // Mouth
    public void SelectedMouth1()
    {
        selectedMouth = true;
        ConfirmedMouth.GetComponent<Image>().sprite = MouthOne.GetComponent<Image>().sprite;
    }
    public void SelectedMouth2()
    {
        selectedMouth = true;
        ConfirmedMouth.GetComponent<Image>().sprite = MouthTwo.GetComponent<Image>().sprite;
    }
    public void SelectedMouth3()
    {
        selectedMouth = true;
        ConfirmedMouth.GetComponent<Image>().sprite = MouthThree.GetComponent<Image>().sprite;
    }
    public void SelectedMouth4()
    {
        selectedMouth = true;
        ConfirmedMouth.GetComponent<Image>().sprite = MouthFour.GetComponent<Image>().sprite;
    }
}
