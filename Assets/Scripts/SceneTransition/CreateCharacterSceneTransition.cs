using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateCharacterSceneTransition : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //SceneManager.LoadScene("Game");
    public void ToBack()
    {
        SceneManager.LoadScene("SelectCharacter");
    }
    public void ToCreate() { SceneManager.LoadScene("SelectCharacter"); }
}
