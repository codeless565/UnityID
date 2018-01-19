using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JoyControl : MonoBehaviour {

    [SerializeField]
    GameObject player;

    private Image joyFG;
    private Image joyBG;
    public Vector3 direction;
    Vector3 startPosition;
    float radius = 100;

    [SerializeField]
    GameObject joyObj;

    bool dragging;

    // Use this for initialization
    void Start () {
        joyBG = joyObj.GetComponent<Image>();
        joyFG = joyObj.transform.GetChild(0).GetComponent<Image>();

        startPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1);
        dragging = false;
    }

    // Update is called once per frame
    void Update () {

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (Application.platform == RuntimePlatform.Android)
                Application.Quit();
        }

        //PlayerMovement
        if (dragging)
        {
#if UNITY_EDITOR || UNITY_WINDOWS
            if ((new Vector2(Input.mousePosition.x, Input.mousePosition.y) - new Vector2(joyBG.transform.position.x, joyBG.transform.position.y)).magnitude >= radius * 0.3f)
                player.GetComponent<PlayerMovement>().Move();
            #elif UNITY_ANDROID || UNITY_IOS
            Touch mytouch = Input.GetTouch(0);
            if ((new Vector2(mytouch.position.x, mytouch.position.y) - new Vector2(joyBG.transform.position.x, joyBG.transform.position.y)).magnitude >= radius *0.3f)
                player.GetComponent<PlayerMovement>().Move();
            #endif
        }
    }

    public void InitialPos()
    {
        #if UNITY_EDITOR
                startPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1);

#elif UNITY_ANDROID || UNITY_IOS
                Touch myTouch = Input.GetTouch(0);
                startPosition = new Vector3(myTouch.position.x, myTouch.position.y);
#else
                startPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1);
#endif

        dragging = true;
    }

    public void Dragging()
    {
        Vector3 newPosition;

        #if UNITY_EDITOR || UNITY_WINDOWS
                Vector2 tempPosition = new Vector2(Input.mousePosition.x - startPosition.x, Input.mousePosition.y - startPosition.y);

        #elif UNITY_ANDROID || UNITY_IOS
                Touch mytouch = Input.GetTouch(0);
                Vector2 tempPosition = new Vector3(mytouch.position.x - startPosition.x, mytouch.position.y - startPosition.y, 1);
        #endif

        //Restrict to joycontrol area
        Vector2 clampPos = Vector2.ClampMagnitude(new Vector2(tempPosition.x, tempPosition.y), radius);
        newPosition = new Vector3(clampPos.x, clampPos.y, 1);

        joyFG.rectTransform.localPosition = newPosition;
        direction = joyFG.rectTransform.localPosition;

    }

    public void StopDrag()
    {
        joyFG.rectTransform.localPosition = new Vector3(0, 0, 1);
        dragging = false;
    }
}