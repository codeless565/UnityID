using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleCometMovement : MonoBehaviour {

    [SerializeField]
    float CometSpeed = 20;

    [SerializeField]
    float LifeTime = 20;

    [SerializeField]
    ParticleSystem EndEffects;

    float CometDMG;
    float ElaspeTime;

    // Use this for initialization
    void Start () {
        ElaspeTime = 0;
        CometDMG = GameObject.FindGameObjectWithTag("SkillPrefabHolder").GetComponent<SkillDoubleComet>().GetDamage();
    }
	
	// Update is called once per frame
	void Update () {
        transform.position -= transform.up * CometSpeed * Time.deltaTime;

        ElaspeTime += Time.deltaTime;
        if (ElaspeTime >= LifeTime)
        {
            Destroy(gameObject);
        }
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
            Destroy(gameObject);
        }
    }
}
