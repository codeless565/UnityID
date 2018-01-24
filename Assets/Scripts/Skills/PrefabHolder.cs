using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabHolder : MonoBehaviour {

    public static PrefabHolder instance;

    public GameObject ExplosionSkill;
    public GameObject ExplosionSparkSkill;
    public GameObject ExplosionBurstSkill;

    public GameObject CometSkill;
    public GameObject PenetratingCometSkill;
    public GameObject DoubleCometSkill;

    public GameObject PenetratingBullet;
    public GameObject DoublePenetratingBullet;

    void Awake() // note it's now Awake instead of Start. That's important.
    {
        instance = this; // hold a reference to the (last) instance of this class.
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
