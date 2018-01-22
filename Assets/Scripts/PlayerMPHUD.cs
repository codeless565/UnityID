using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMPHUD : MonoBehaviour {

    [SerializeField]
    GameObject Player;
    public Slider MPBarObject;

    //Variable 
    float MaxMP;
    float currMp;

	// Use this for initialization
	void Start () {
        MaxMP = Player.GetComponent<Health>().hp;
        currMp = MaxMP;

        MPBarObject.value = CalculatePercentage();
    }

    // Update is called once per frame
    void Update () {
        currMp = Player.GetComponent<PlayerMana>().mp;
        MPBarObject.value = CalculatePercentage();
    }

    float CalculatePercentage()
    {
        return currMp / MaxMP;
    }
}
