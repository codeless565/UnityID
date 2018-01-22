using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHPHUD : MonoBehaviour {

    [SerializeField]
    GameObject Player;
    public Slider HPBarObject;

    //Variable 
    float MaxHP;
    float currHp;

	// Use this for initialization
	void Start () {
        MaxHP = Player.GetComponent<Health>().hp;
        currHp = MaxHP;

        HPBarObject.value = CalculateHealth();
    }

    // Update is called once per frame
    void Update () {
	    if (Input.GetKeyDown(KeyCode.X))
        {
            Player.GetComponent<Health>().hp -= 10;
        }	

        currHp = Player.GetComponent<Health>().hp;
        HPBarObject.value = CalculateHealth();
    }

    float CalculateHealth()
    {
        return currHp / MaxHP;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Enemy"))
        {
            Player.GetComponent<Health>().AddHealth(-5f);
        }
    }

}
