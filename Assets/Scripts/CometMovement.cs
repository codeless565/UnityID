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

        Health healthscript = other.GetComponent<Health>();

        if (healthscript != null)
        {
            ParticleSystem thisExplosion = Instantiate(EndEffects, transform.position, Quaternion.identity);
            thisExplosion.Play();

            healthscript.AddHealth(-CometDMG);
        }

        Destroy(gameObject);
    }
}
