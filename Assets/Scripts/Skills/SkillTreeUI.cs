using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillTreeUI : MonoBehaviour {

    [SerializeField]
    GameObject Owner;

    [SerializeField]
    GameObject DisplayPanel;

    [SerializeField]
    Image SkillImage;

    [SerializeField]
    Button RankUpButton;

    [SerializeField]
    Text SkillName;

    [SerializeField]
    Text SkillLevel;

    [SerializeField]
    Text SkillRankupCost;

    [SerializeField]
    Text SkillDescription;

    [SerializeField]
    Text SkillPoints;

    [SerializeField]
    Color ClickableColor = Color.white;
    [SerializeField]
    Color UnClickableColor = Color.gray;

    //Variables
    SkillBase selectedSkill;

    // Use this for initialization
    void Start () {
        selectedSkill = null;
        DisplayPanel.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (selectedSkill != null)
        {//Something is selected
            DisplayPanel.SetActive(true);
            if (Owner.GetComponent<GOStats>().GetSkillPoints() >= selectedSkill.GetRankupCost())
            {
                RankUpButton.interactable = true;
                RankUpButton.GetComponent<Image>().color = ClickableColor;
            }
            else
            {
                RankUpButton.interactable = false;
                RankUpButton.GetComponent<Image>().color = UnClickableColor;
            }

            //load the text and images
            SkillImage.sprite = selectedSkill.GetSkillImage();
            SkillName.text = selectedSkill.GetName();
            if (selectedSkill.GetLevel() <= 0)
            {
                SkillLevel.text = "Not Available";
                RankUpButton.GetComponentInChildren<Text>().text = "Unlock";
            }
            else
            {
                SkillLevel.text = "Rank " + selectedSkill.GetLevel().ToString();
                RankUpButton.GetComponentInChildren<Text>().text = "Rank up";
            }
            SkillRankupCost.text = "Rankup Cost: " + selectedSkill.GetRankupCost().ToString();
            SkillDescription.text = selectedSkill.GetDescription() + "\nSkill Damage: " + selectedSkill.GetDamage().ToString("0") + "\n" + "Mana Cost: " + selectedSkill.GetManaCost().ToString("0");
        }
        SkillPoints.text = "Skill Points: " + Owner.GetComponent<GOStats>().GetSkillPoints().ToString();
	}

    public void RankUpSelectedSkill()
    {
        if (Owner.GetComponent<GOStats>().GetSkillPoints() >= selectedSkill.GetRankupCost())
        {
            Owner.GetComponent<GOStats>().DeductSkillPoints(selectedSkill.GetRankupCost());
            selectedSkill.RankUp();
        }
    }

    //Selecting Skills
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
