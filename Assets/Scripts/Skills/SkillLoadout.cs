using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillLoadout : MonoBehaviour {

    [SerializeField]
    GameObject Owner;

    [SerializeField]
    GameObject SkillPanel;

    [SerializeField]
    Text SkillName;

    [SerializeField]
    Text SkillDescription;

    //Loadout
    [SerializeField]
    Button SkillTop;
    [SerializeField]
    Button SkillRight;
    [SerializeField]
    Button SkillBottom;
    [SerializeField]
    Button SkillLeft;

    //Color
    [SerializeField]
    Sprite emptySlot;
    [SerializeField]
    Color SelectedColor = Color.cyan;
    [SerializeField]
    Color NotSelectedColor = Color.white;

    Button selectedButton;
    SkillBase selectedSkill;

    // Use this for initialization
    void Start () {
        ResetToDefault();

        SkillTop.image.sprite = emptySlot;
        SkillRight.image.sprite = emptySlot;
        SkillBottom.image.sprite = emptySlot;
        SkillLeft.image.sprite = emptySlot;
    }
	
	// Update is called once per frame
	void Update () {
        if (selectedButton != null)
        {
            SkillPanel.SetActive(true);

            if (selectedSkill != null)
            {
                SkillName.text = selectedSkill.GetName() + "   Rank " + selectedSkill.GetLevel().ToString();
                SkillDescription.text = selectedSkill.GetDescription() + "\nDamage: " + selectedSkill.GetDamage().ToString("0") + "\nMana Cost: " + selectedSkill.GetManaCost().ToString("0");
            }
        }
	}

    void ResetToDefault()
    {
        selectedButton = null;
        selectedSkill = null;
        SkillPanel.SetActive(false);
    }


    //Equip Skill to Loadout
    public void EquipSkill()
    {
        if (selectedButton == SkillTop)
        {
            SkillTop.image.sprite = selectedSkill.GetSkillImage();
            Owner.GetComponent<SkillControl>().SetSkillTop(selectedSkill);
        }
        else if (selectedButton == SkillRight)
        {
            SkillRight.image.sprite = selectedSkill.GetSkillImage();
            Owner.GetComponent<SkillControl>().SetSkillRight(selectedSkill);
        }
        else if (selectedButton == SkillBottom)
        {
            SkillBottom.image.sprite = selectedSkill.GetSkillImage();
            Owner.GetComponent<SkillControl>().SetSkillBottom(selectedSkill);
        }
        else if (selectedButton == SkillLeft)
        {
            SkillLeft.image.sprite = selectedSkill.GetSkillImage();
            Owner.GetComponent<SkillControl>().SetSkillLeft(selectedSkill);
        }
        ResetToDefault();
    }

    //Remove Skill From Loadout
    public void RemoveSkill()
    {
        if (selectedButton == SkillTop)
        {
            SkillTop.image.sprite = emptySlot;
            Owner.GetComponent<SkillControl>().SetSkillTop(null);
        }
        else if (selectedButton == SkillRight)
        {
            SkillRight.image.sprite = emptySlot;
            Owner.GetComponent<SkillControl>().SetSkillRight(null);
        }
        else if (selectedButton == SkillBottom)
        {
            SkillBottom.image.sprite = emptySlot;
            Owner.GetComponent<SkillControl>().SetSkillBottom(null);
        }
        else if (selectedButton == SkillLeft)
        {
            SkillLeft.image.sprite = emptySlot;
            Owner.GetComponent<SkillControl>().SetSkillLeft(null);
        }
        ResetToDefault();
    }

    //Select to Load-in
    public void SelectedTop()
    {
        selectedButton = SkillTop;
        selectedButton.image.color = SelectedColor;
        SkillRight.image.color = NotSelectedColor;
        SkillBottom.image.color = NotSelectedColor;
        SkillLeft.image.color = NotSelectedColor;
    }
    public void SelectedRight()
    {
        selectedButton = SkillRight;
        selectedButton.image.color = SelectedColor;
        SkillTop.image.color = NotSelectedColor;
        SkillBottom.image.color = NotSelectedColor;
        SkillLeft.image.color = NotSelectedColor;
    }
    public void SelectedBottom()
    {
        selectedButton = SkillBottom;
        selectedButton.image.color = SelectedColor;
        SkillTop.image.color = NotSelectedColor;
        SkillRight.image.color = NotSelectedColor;
        SkillLeft.image.color = NotSelectedColor;
    }
    public void SelectedLeft()
    {
        selectedButton = SkillLeft;
        selectedButton.image.color = SelectedColor;
        SkillTop.image.color = NotSelectedColor;
        SkillRight.image.color = NotSelectedColor;
        SkillBottom.image.color = NotSelectedColor;
    }


    //Select Skill
    public void SelectedSkill1_Explosion()
    {
        selectedSkill = GameObject.FindGameObjectWithTag("SkillPrefabHolder").GetComponent<SkillExplosion>();
    }

    public void SelectedSkill2_ExplosionSpark()
    {
        selectedSkill = GameObject.FindGameObjectWithTag("SkillPrefabHolder").GetComponent<SkillExplosionSpark>();
    }

    public void SelectedSkill3_ExplosionBurst()
    {
        selectedSkill = GameObject.FindGameObjectWithTag("SkillPrefabHolder").GetComponent<SkillExplosionBurst>();
    }

    public void SelectedSkill4_Comet()
    {
        selectedSkill = GameObject.FindGameObjectWithTag("SkillPrefabHolder").GetComponent<SkillComet>();
    }

    public void SelectedSkill5_PenetratingComet()
    {
        selectedSkill = GameObject.FindGameObjectWithTag("SkillPrefabHolder").GetComponent<SkillPenetratingComet>();
    }

    public void SelectedSkill6_DoubleComet()
    {
        selectedSkill = GameObject.FindGameObjectWithTag("SkillPrefabHolder").GetComponent<SkillDoubleComet>();
    }

    public void SelectedSkill7_PenetratingBullet()
    {
        selectedSkill = GameObject.FindGameObjectWithTag("SkillPrefabHolder").GetComponent<SkillPenetratingBullet>();
    }

    public void SelectedSkill8_DoublePenetratingBullet()
    {
        selectedSkill = GameObject.FindGameObjectWithTag("SkillPrefabHolder").GetComponent<SkillDoublePenetratingBullet>();
    }
}
