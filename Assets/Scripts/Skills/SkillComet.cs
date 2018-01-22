using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillComet : MonoBehaviour, SkillBase
{
    public GameObject Comet;

    // Use this for initialization
    void Awake() {
      
        Comet = GameObject.Find("Player").GetComponentInChildren<PrefabHolder>().CometSkill;
    }

    // Update is called once per frame
    void Update () {
		
	}

    void SkillBase.SkillCall()
    {
        Vector3 newPos = new Vector3(transform.position.x, transform.position.y + 20, transform.position.z);
         
        Instantiate(Comet, newPos, transform.rotation);
    }

    float SkillBase.GetCost()
    {
        return 20;
    }

}
