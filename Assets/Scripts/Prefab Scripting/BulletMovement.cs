using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {

    [SerializeField]
    float BulletSpeed = 20;
    [SerializeField]
    float BulletDMG = 1;
    [SerializeField]
    ParticleSystem Explosion;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.up * BulletSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {

        GOStats statsScript = other.GetComponent<GOStats>();

        if(statsScript != null)
        {
            ParticleSystem thisExplosion = Instantiate(Explosion, transform.position, Quaternion.identity);
            thisExplosion.Play();

            statsScript.AddHealth(-BulletDMG);
            if (statsScript.GetHP() <= 0)
                GameObject.FindGameObjectWithTag("Player").GetComponent<GOStats>().AddEXP(10);
        }

        Destroy(gameObject);
    }
}
