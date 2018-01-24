using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillDoublePenetratingBullet : MonoBehaviour, SkillBase
{
    [SerializeField]
    GameObject Bullet;

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
        Vector3 BulletSpawnpt = GameObject.FindGameObjectWithTag("BulletSpawn").transform.position;
        Vector3 newPos = new Vector3(BulletSpawnpt.x - 2, BulletSpawnpt.y, BulletSpawnpt.z);
        Vector3 newPos2 = new Vector3(BulletSpawnpt.x + 2, BulletSpawnpt.y, BulletSpawnpt.z);

        Instantiate(Bullet, newPos, GameObject.FindGameObjectWithTag("BulletSpawn").transform.rotation);
        Instantiate(Bullet, newPos2, GameObject.FindGameObjectWithTag("BulletSpawn").transform.rotation);
    }

    public float GetManaCost()
    {
        return currLevel * 10 + 8;
    }

    public float GetDamage()
    {
        return currLevel * 10;
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
        return "Shoot 2 extremely sharp projectile to attack any enemies in its path.\n";
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
        return "Double Piercing Bullet";
    }
}
