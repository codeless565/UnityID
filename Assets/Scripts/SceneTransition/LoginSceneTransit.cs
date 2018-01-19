using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginSceneTransit : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //SceneManager.LoadScene("Game");
    public void ToExit()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (Application.platform == RuntimePlatform.Android)
                Application.Quit();
        }
    }
    public void ToGooglePlus() { Debug.Log("To Google Sign in"); }
    public void ToFacebook() { Debug.Log("To Facebook Sign in"); }
    public void ToGuest()
    {
        SceneManager.LoadScene("AccountInfo");
    }
}
