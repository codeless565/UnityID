using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurstExplosion : MonoBehaviour {

    float DestroyTimer;

	// Use this for initialization
	void Start () {
        DestroyTimer = 0;
	}
	
	// Update is called once per frame
	void Update () {
        DestroyTimer += Time.deltaTime;

        if(DestroyTimer >= 5.0f)
        {
            Destroy(gameObject);
        }
	}
}
