using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillExplosion : MonoBehaviour, SkillBase
{
    public GameObject Explosion;

    // Use this for initialization
    void Awake () {
        Explosion = GameObject.Find("Player").GetComponentInChildren<PrefabHolder>().ExplosionSkill;
    }

    // Update is called once per frame
    void Update () {
		
	}

    void SkillBase.SkillCall()
    {
       Instantiate(Explosion, transform.position, transform.rotation);
    }
}
