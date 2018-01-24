using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillComet : MonoBehaviour, SkillBase
{
    [SerializeField]
    GameObject Comet;

    [SerializeField]
    Sprite SkillIcon;

    //Variables
    int currLevel = 0;

    // Use this for initialization
    void Start()
    {  
        currLevel = 0;
    }

    // Update is called once per frame
    void Update () {
		
	}

    void SkillBase.SkillCall()
    {
        Vector3 CometSpawnpt = GameObject.FindGameObjectWithTag("CometSpawn").transform.position;

        Instantiate(Comet, CometSpawnpt, transform.rotation);
    }

    public float GetManaCost()
    {
        return currLevel * 5 + 10;
    }

    public float GetDamage()
    {
        return currLevel * 20;
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
        return "Calls down a giant meteor from the sky to destroy any enemy infront of the caster.\n";
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
        return "Comet";
    }
}
