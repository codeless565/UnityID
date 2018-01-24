using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillExplosionBurst : MonoBehaviour, SkillBase
{
    [SerializeField]
    GameObject Explosion;

    [SerializeField]
    Sprite SkillIcon;

    //Variables
    int currLevel;

    // Use this for initialization
    void Start()
    {
        currLevel = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SkillBase.SkillCall()
    {
        Instantiate(Explosion, transform.position, transform.rotation);
    }

    public float GetManaCost()
    {
        return currLevel * 10;
    }

    public float GetDamage()
    {
        return 0;
    }

    public int GetLevel()
    {
        return currLevel;
    }

    public int GetRankupCost()
    {
        if (currLevel <= 0)
            return 3;
        else
            return 1;
    }

    public string GetDescription()
    {
        return "Generates multiple wide Area of Effect spark to ward off enemies for a period of time.\n";
    }

    public void RankUp()
    {
        ++currLevel;
    }

    public Sprite GetSkillImage()
    {
        return SkillIcon;
    }

    public string GetName()
    {
        return "Rapid Explosion";
    }

}