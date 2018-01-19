using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillComet : MonoBehaviour, SkillBase
{
    public GameObject Comet;
    GameObject player;

    // Use this for initialization
    void Start () {
      
        Comet = (GameObject)UnityEditor.AssetDatabase.LoadAssetAtPath("Assets/Prefabs/Comet.prefab", typeof(GameObject));
    }

    // Update is called once per frame
    void Update () {
		
	}

    void SkillBase.SkillCall()
    {
        Vector3 newPos = new Vector3(transform.position.x, transform.position.y + 20, transform.position.z);
         
        Instantiate(Comet, newPos, transform.rotation);
    }

}
