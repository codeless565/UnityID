using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    [SerializeField]
    int Gold = 1000;

    [SerializeField]
    Text InventoryDisplay;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            Gold += 1000;
        }

        InventoryDisplay.text = Gold.ToString();
    }

    public void AddGold(int amt)
    {
        Gold += amt;
    }

    public int GetGold()
    {
        return Gold;
    }


}
