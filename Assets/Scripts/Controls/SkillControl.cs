﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillControl : MonoBehaviour
{
    [SerializeField]
    GameObject Player;

    [SerializeField]
    GameObject SkillControllerObj;

    [SerializeField]
    GameObject SkillLoadoutDisplay;

    [SerializeField]
    GameObject NormalAttackGameObject;
    
    SkillBase SkillFirst;
    SkillBase SkillSecond;
    SkillBase SkillThird;
    SkillBase SkillFourth;


    private Image skillBG;
    private Image skillFG;
    public Vector3 direction;
    Vector3 startPosition;
    Vector3 liftPosition;

    float NormalAttackLimit = 100;
    float DragLimit = 200;

    // Use this for initialization
    void Start () {
        skillBG = SkillControllerObj.GetComponent<Image>();
        skillFG = SkillControllerObj.transform.GetChild(0).GetComponent<Image>();

        //Add skill
        SkillFirst = null;
        SkillSecond = null;
        SkillThird = null;
        SkillFourth = null;

        startPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1);
    }

    // Update is called once per frame
    void Update () {

    }

    public void InitialPos()
    {
        #if UNITY_EDITOR
                startPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1);

        #elif UNITY_ANDROID || UNITY_IOS
                Touch myTouch = Input.GetTouch(0);
                startPosition = new Vector3(myTouch.position.x, myTouch.position.y);
        #else
                startPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1);
        #endif
    }

    public void Dragging()
    {
        
        #if UNITY_EDITOR || UNITY_WINDOWS
                Vector2 tempPosition = new Vector2(Input.mousePosition.x - startPosition.x, Input.mousePosition.y - startPosition.y);

        #elif UNITY_ANDROID || UNITY_IOS
                Touch mytouch = Input.GetTouch(0);
                Vector3 tempPosition = new Vector3(mytouch.position.x - startPosition.x, mytouch.position.y - startPosition.y, 1);

        #endif

        Vector2 clampPos = Vector2.ClampMagnitude(new Vector2(tempPosition.x, tempPosition.y), DragLimit);
        liftPosition = new Vector3(clampPos.x, clampPos.y, 1);
        
        skillFG.rectTransform.localPosition = liftPosition;
        direction = skillFG.rectTransform.localPosition;

        //Only Show Skill Display when dragging out of NormalAttackLimit
        if (liftPosition.magnitude >= NormalAttackLimit)
            SkillLoadoutDisplay.SetActive(true);
        else
            SkillLoadoutDisplay.SetActive(false);
    }

    public void StopDrag()
    {
        //call skill activate check with current pos
        if (liftPosition.magnitude < NormalAttackLimit)
        {
            BasicAttack();
        }
        else
        {
            float degrees = Vector3.Angle(direction, transform.up);
            //there is no negative or >180 in this calculation, so we need to manually apply a negative
            if (direction.x < 0)
                degrees *= -1;

            if (degrees >= 45 && degrees < 135) //Right Skill
                SkillCall_Right();
            else if (degrees >= 135 || degrees < -135) //Down Skill
                SkillCall_Down();
            else if (degrees < -45 && degrees >= -135) //Left Skill
                SkillCall_Left();
            else //up Skill
                SkillCall_Up();
        }
        //Reset all to default
        skillFG.rectTransform.localPosition = new Vector3(0, 0, 1);
        liftPosition = new Vector3(0, 0, 1);
        SkillLoadoutDisplay.SetActive(false);
    }

    //Basic Attack
    private void BasicAttack()
    {
        //Call object and find script to call script's function
        NormalAttackGameObject.GetComponent<PlayerFire>().Fire();
    }

    //Skill Activation
    private void SkillCall_Up()
    {
        if (SkillFirst == null)
            return;
        if (Player.GetComponent<GOStats>().GetMP() < SkillFirst.GetManaCost())
            return;

        SkillFirst.SkillCall();
        Player.GetComponent<GOStats>().AddMP(-SkillFirst.GetManaCost());
    }

    private void SkillCall_Right()
    {
        if (SkillSecond == null)
            return;
        if (Player.GetComponent<GOStats>().GetMP() < SkillSecond.GetManaCost())
            return;

        SkillSecond.SkillCall();
        Player.GetComponent<GOStats>().AddMP(-SkillSecond.GetManaCost());
    }

    private void SkillCall_Down()
    {
        if (SkillThird == null)
            return;
        if (Player.GetComponent<GOStats>().GetMP() < SkillThird.GetManaCost())
            return;

        SkillThird.SkillCall();
        Player.GetComponent<GOStats>().AddMP(-SkillThird.GetManaCost());
    }

    private void SkillCall_Left()
    {
        if (SkillFourth == null)
            return;
        if (Player.GetComponent<GOStats>().GetMP() < SkillFourth.GetManaCost())
            return;

        SkillFourth.SkillCall();
        Player.GetComponent<GOStats>().AddMP(-SkillFourth.GetManaCost());
    }

    //Skill Loadout
    public void SetSkillTop(SkillBase newSkill)
    {
        SkillFirst = newSkill;
    }

    public void SetSkillRight(SkillBase newSkill)
    {
        SkillSecond = newSkill;
    }

    public void SetSkillBottom(SkillBase newSkill)
    {
        SkillThird = newSkill;
    }

    public void SetSkillLeft(SkillBase newSkill)
    {
        SkillFourth = newSkill;
    }
}