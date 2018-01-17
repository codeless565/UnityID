using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour {

    [SerializeField]
    GameObject bullet;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
#if UNITY_EDITOR
        if (Input.GetKey(KeyCode.Space))
            Fire();   
#endif
    }

    public void Fire ()
    {
        Instantiate(bullet, transform.position, transform.rotation);
    }
}
