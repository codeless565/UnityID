using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GOStats : MonoBehaviour
{
    [SerializeField]
    int Level;
    [SerializeField]
    float maxHP = 100;
    [SerializeField]
    float maxMP = 100;

    float hp;
    float mp;
    float expCAP;
    float exp;

    int Statspoints;
    int STR;
    int AGI;
    int INT;

    //Buttons - Player only
    public GameObject STRButton;
    public GameObject AGIButton;
    public GameObject INTButton;

    //Displays - Player only
    public Text LEVEL_DISPLAY;
    public Text HP_DISPLAY;
    public Text MP_DISPLAY;
    public Text EXP_DISPLAY;
    public Text STATSPOINTS_DISPLAY;
    public Text STR_DISPLAY;
    public Text AGI_DISPLAY;
    public Text INT_DISPLAY;
    public Text HP_HUD;
    public Text MP_HUD;

    //HUD - Player only
    public Slider HPBAR;
    public Slider MPBAR;
    public Slider EXPBAR;

    // Use this for initialization
    void Start()
    {
        //Pre Set
        hp = maxHP;
        mp = maxMP;
        exp = 0;

        //Base Stats
        STR = 10;
        AGI = 10;
        INT = 10;

        //Preset Stats by Level
        expCAP = Level * 10;
        Statspoints = Level * 10;
    }

    // Update is called once per frame
    void Update()
    {
        hp += ((Level * STR + AGI) * 0.1f) * Time.deltaTime;
        mp += (Level * INT) * 0.1f * Time.deltaTime;

        //capacity limit
        if (hp <= 0)
            hp = 0;
        if (hp >= maxHP)
            hp = maxHP;

        if (mp <= 0)
            mp = 0;
        if (mp >= maxMP)
            mp = maxMP;

        if (this.gameObject.name.Contains("Enemy"))
            return;

        //Level Up
        if (exp >= expCAP)
        {
            ++Level;
            expCAP += Level * 10;
            exp = 0;

            Statspoints += 10;
            maxHP += Level * 10 + Level;
            maxMP += Level * 10 + Level * 2;

            hp = maxHP;
            mp = maxMP;
        }

        //Button to add stats only appear if there are pts available
        if (Statspoints > 0)
        {
            STRButton.SetActive(true);
            AGIButton.SetActive(true);
            INTButton.SetActive(true);
        }
        else
        {
            STRButton.SetActive(false);
            AGIButton.SetActive(false);
            INTButton.SetActive(false);
        }

        //Display
        LEVEL_DISPLAY.text = Level.ToString();
        HP_DISPLAY.text = hp.ToString("0") + " / " + maxHP.ToString("0");
        MP_DISPLAY.text = mp.ToString("0") + " / " + maxMP.ToString("0");
        EXP_DISPLAY.text = exp.ToString() + " / " + expCAP.ToString();
        STATSPOINTS_DISPLAY.text = Statspoints.ToString();
        STR_DISPLAY.text = STR.ToString();
        AGI_DISPLAY.text = AGI.ToString();
        INT_DISPLAY.text = INT.ToString();

        HPBAR.value = CalculatePercentage(hp, maxHP);
        MPBAR.value = CalculatePercentage(mp, maxMP);
        EXPBAR.value = CalculatePercentage(exp, expCAP);

        HP_HUD.text = (CalculatePercentage(hp, maxHP) * 100).ToString("0") + "%";
        MP_HUD.text = (CalculatePercentage(mp, maxMP) * 100).ToString("0") + "%";
    }

    //Health
    public void AddHealth(float amt)
    {
        hp += amt;

        if (hp <= 0)
            Destroy(this.gameObject);
    }

    public void AddMP(float amt)
    {
        mp += amt;
    }

    public void AddEXP(int amt)
    {
        exp += amt;
    }


    //Buttons
    public void AddSTR()
    {
        if (Statspoints <= 0)
            return;

        --Statspoints;
        ++STR;
    }

    public void AddAGI()
    {
        if (Statspoints <= 0)
            return;

        --Statspoints;
        ++AGI;
    }

    public void AddINT()
    {
        if (Statspoints <= 0)
            return;

        --Statspoints;
        ++INT;
    }



    //Getters
    public float GetHP()
    { return hp; }

    public float GetMaxHP()
    { return maxHP; }

    public float GetMP()
    { return mp; }

    public float GetMaxMP()
    { return maxMP; }


    //Helper
    float CalculatePercentage(float min, float max)
    {
        return min / max;
    }
    float CalculatePercentage(int min, int max)
    {
        return min / max;
    }

}

