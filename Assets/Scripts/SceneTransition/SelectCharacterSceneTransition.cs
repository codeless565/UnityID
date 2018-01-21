using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectCharacterSceneTransition : MonoBehaviour
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
    public void ToBack()
    {
        SceneManager.LoadScene("AccountInfo");
    }
    public void ToCreate() { Debug.Log("To Create"); }
    public void ToDelete() { Debug.Log("To Delete"); }
    public void ToPlay()
    {
        SceneManager.LoadScene("Game");
    }
}
