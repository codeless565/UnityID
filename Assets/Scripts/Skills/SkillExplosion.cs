using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillExplosion : MonoBehaviour, SkillBase
{
    public GameObject Explosion;

	// Use this for initialization
	void Start () {
        Explosion = (GameObject)UnityEditor.AssetDatabase.LoadAssetAtPath("Assets/Prefabs/Skill_Explosion.prefab", typeof(GameObject)); ;
    }

    // Update is called once per frame
    void Update () {
		
	}

    void SkillBase.SkillCall()
    {
       Instantiate(Explosion, transform.position, transform.rotation);
    }
}
