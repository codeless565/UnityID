using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float movementSpeed = 10;

    [SerializeField]
    float rotateSpeed = 60;

    [SerializeField]
    GameObject UIObj;

    Vector3 yAxis;
    JoyControl targetScript;

    protected void Awake()
    {
        // Debug.Log("Awake");
    }

    // Use this for initialization
    protected void Start()
    {
        //Debug.Log("Start");
        yAxis = new Vector3(0, 1, 0);
        targetScript = UIObj.GetComponent<JoyControl>();
    }

    // Update is called once per frame
    protected void Update()
    {
#if UNITY_EDITOR || UNITY_WINDOWS
        //WASD Movement
        if (Input.GetKey(KeyCode.W))
        {
            //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + movementSpeed);
            transform.position += transform.forward * movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - movementSpeed);
            transform.position -= transform.forward * movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            //transform.position = new Vector3(transform.position.x - movementSpeed, transform.position.y, transform.position.z);
            transform.position -= transform.right * movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            //transform.position = new Vector3(transform.position.x + movementSpeed, transform.position.y, transform.position.z);
            transform.position += transform.right * movementSpeed * Time.deltaTime;
        }
#elif UNITY_ANDROID || UNITY_IOS
#else
#endif
        Rotate();
    }

    protected void LateUpdate()
    {
        //Debug.Log("LateUpdate");
    }

    public void Rotate()
    {
        Vector3 targetDir = targetScript.direction;

        Vector3 newDir = Vector3.RotateTowards(transform.forward,
                            new Vector3(targetDir.x, 0.0f, targetDir.y),
                             Time.deltaTime * rotateSpeed, 0.0F);


        transform.rotation = Quaternion.LookRotation(newDir);
    }

    public void Move()
    {
        transform.position += transform.forward * movementSpeed * Time.deltaTime;
    }
}
