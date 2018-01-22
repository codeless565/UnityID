using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMana : MonoBehaviour {

    public float mp = 100;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        mp += 1 * Time.deltaTime;

        if (mp <= 0)
            mp = 0;

        if (mp >= 100)
            mp = 100;
	}
}
