using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverlayManager : MonoBehaviour {

    //Set Canvas of each overlay
    [SerializeField]
    GameObject Map;

    //Boolean for overlays
    bool b_MapOpen;

	// Use this for initialization
	void Start () {
        b_MapOpen = false;		
	}
	
	// Update is called once per frame
	void Update () {
        Map.SetActive(b_MapOpen);
	}

    public void Map_Open()
    {
        Debug.Log("Map_Opened");
        b_MapOpen = true;
    }

    public void Map_Close()
    {
        Debug.Log("Map_Closed");
        b_MapOpen = false;
    }
}
