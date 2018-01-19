using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AccountInfoSceneTransit : MonoBehaviour {
    [SerializeField]
    GameObject AccountTab;

    bool b_accountOpen;


	// Use this for initialization
	void Start () {
        b_accountOpen = false;
    }
	
	// Update is called once per frame
	void Update () {
        AccountTab.SetActive(b_accountOpen);

        if (Input.GetKeyUp(KeyCode.Escape))
            Application.Quit();
    }

    //SceneManager.LoadScene("Game");
    public void ToAccount()
    {
        accountOpen();
    }
    public void ToSelectCharacter() { SceneManager.LoadScene("SelectCharacter"); }
    public void ToOptions() { Debug.Log("To Options"); }
    public void ToExit() {
        if (Application.platform == RuntimePlatform.Android)
            Application.Quit();

    }

    public void accountOpen()
    {
        Debug.Log("Account Information Tab Open");
        b_accountOpen = true;
    }
    public void accountClose()
    {
        Debug.Log("Account Information Tab Closed");
        b_accountOpen = false;
    }

    //Cheat to Game
    public void ToGame() { SceneManager.LoadScene("Game"); }
}
