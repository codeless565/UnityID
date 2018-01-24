using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenetratingBulletMovement : MonoBehaviour {

    [SerializeField]
    float BulletSpeed = 20;

    [SerializeField]
    float LifeTime = 10;

    [SerializeField]
    ParticleSystem Explosion;

    float BulletDMG;
    float ElaspeTime;

	// Use this for initialization
	void Start () {
        BulletDMG = GameObject.FindGameObjectWithTag("SkillPrefabHolder").GetComponent<SkillPenetratingBullet>().GetDamage();
        ElaspeTime = 0;
    }
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.up * BulletSpeed * Time.deltaTime;

        ElaspeTime += Time.deltaTime;
        if(ElaspeTime >= LifeTime)
        {
            Destroy(gameObject);
        }
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
    }
}
