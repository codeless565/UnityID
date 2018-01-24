using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillDoubleComet : MonoBehaviour, SkillBase
{
    [SerializeField]
    GameObject Comet;

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
    void Update () {
		
	}

    void SkillBase.SkillCall()
    {
        Vector3 CometSpawnpt = GameObject.FindGameObjectWithTag("CometSpawn").transform.position;
        Vector3 newPos = new Vector3(CometSpawnpt.x + 5, CometSpawnpt.y, CometSpawnpt.z);
        Vector3 newPos2 = new Vector3(CometSpawnpt.x - 5, CometSpawnpt.y, CometSpawnpt.z);

        Instantiate(Comet, newPos, transform.rotation);
        Instantiate(Comet, newPos2, transform.rotation);
    }

    public float GetManaCost()
    {
        return currLevel * 10 + 10;
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
        return "Calls down 2 giant meteor in a sequence from the sky to destroy any enemy infront of the caster.\n";
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
        return "Double Comet";
    }
}
