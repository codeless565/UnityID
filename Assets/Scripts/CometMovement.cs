using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CometMovement : MonoBehaviour {

    [SerializeField]
    float CometSpeed = 20;
    [SerializeField]
    float CometDMG = 1;
    [SerializeField]
    ParticleSystem EndEffects;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position -= transform.up * CometSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {

        GOStats statsScript = other.GetComponent<GOStats>();

        if (statsScript != null)
        {
            ParticleSystem thisExplosion = Instantiate(EndEffects, transform.position, Quaternion.identity);
            thisExplosion.Play();

            statsScript.AddHealth(-CometDMG);
            if (statsScript.GetHP() <= 0)
                GameObject.FindGameObjectWithTag("Player").GetComponent<GOStats>().AddEXP(10);
        }

        Destroy(gameObject);
    }
}
