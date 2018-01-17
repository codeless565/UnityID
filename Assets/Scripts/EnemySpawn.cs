using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    [SerializeField]
    GameObject EnemyObj;

    [SerializeField]
    float SpawnDelay = 1.0f;

    // Use this for initialization
    void Start () {
        StartCoroutine("SpawnEnemy", 2.0f);
	}
	
    IEnumerator SpawnEnemy()
    {
        for (int i = 0; i < 1000; ++i)
        {
            yield return new WaitForSeconds(SpawnDelay);
            Instantiate(EnemyObj, transform.position, Quaternion.identity);
        }
    }

	// Update is called once per frame
	void Update () {
	
	
	}
}
