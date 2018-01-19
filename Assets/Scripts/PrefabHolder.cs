using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabHolder : MonoBehaviour {

    public static PrefabHolder instance;
    public GameObject ExplosionSkill;
    public GameObject CometSkill;

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
