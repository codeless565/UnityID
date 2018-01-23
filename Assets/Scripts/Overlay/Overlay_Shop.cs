using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Overlay_Shop : MonoBehaviour {
    [SerializeField]
    GameObject BuyButton;
    [SerializeField]
    GameObject SellButton;
    [SerializeField]
    GameObject RepairButton;
    [SerializeField]
    GameObject RebuyButton;

    [SerializeField]
    GameObject BuyTab;
    //[SerializeField]
    //GameObject SellTab;
    //[SerializeField]
    //GameObject RepairTab;
    //[SerializeField]
    //GameObject RebuyTab;

    [SerializeField]
    GameObject BuyEquipmentButton;
    [SerializeField]
    GameObject BuyUseButton;
    [SerializeField]
    GameObject BuyMaterialButton;

    [SerializeField]
    GameObject BuyEquipmentTab;
    //[SerializeField]
    //GameObject BuyUseTab;
    //[SerializeField]
    //GameObject BuyMaterialTab;

    [SerializeField]
    GameObject ItemTab;

    bool b_buyOpen;
    bool b_sellOpen;
    bool b_repairOpen;
    bool b_rebuyOpen;

    bool b_buyequipmentOpen;
    bool b_buyuseOpen;
    bool b_buymaterialOpen;

    bool b_itemOpen;


    public Color ButtonActiveColour = Color.red;
    public Color ButtonInactiveColour = Color.cyan;


    // Use this for initialization
    void Start () {
        b_buyOpen = true;
        b_sellOpen = false;
        b_repairOpen = false;
        b_rebuyOpen = false;

        BuyButton.GetComponent<Image>().color = ButtonActiveColour;
        SellButton.GetComponent<Image>().color = ButtonInactiveColour;
        RepairButton.GetComponent<Image>().color = ButtonInactiveColour;
        RebuyButton.GetComponent<Image>().color = ButtonInactiveColour;

        b_buyequipmentOpen = true;
        b_buyuseOpen = false;
        b_buymaterialOpen = false;

        BuyEquipmentButton.GetComponent<Image>().color = ButtonActiveColour;
        BuyUseButton.GetComponent<Image>().color = ButtonInactiveColour;
        BuyMaterialButton.GetComponent<Image>().color = ButtonInactiveColour;

        b_itemOpen = false;
    }
	
	// Update is called once per frame
	void Update () {
        BuyTab.SetActive(b_buyOpen);
        //SellTab.SetActive(b_sellOpen);
        //RepairTab.SetActive(b_repairOpen);
        //RebuyTab.SetActive(b_rebuyOpen);
        
        if (b_buyOpen)
            BuyButton.GetComponent<Image>().color = ButtonActiveColour;
        else
            BuyButton.GetComponent<Image>().color = ButtonInactiveColour;

        if (b_sellOpen)
            SellButton.GetComponent<Image>().color = ButtonActiveColour;
        else
            SellButton.GetComponent<Image>().color = ButtonInactiveColour;

        if (b_repairOpen)
            RepairButton.GetComponent<Image>().color = ButtonActiveColour;
        else
            RepairButton.GetComponent<Image>().color = ButtonInactiveColour;

        if (b_rebuyOpen)
            RebuyButton.GetComponent<Image>().color = ButtonActiveColour;
        else
            RebuyButton.GetComponent<Image>().color = ButtonInactiveColour;

        BuyEquipmentTab.SetActive(b_buyequipmentOpen);
        //BuyUseTab.SetActive(b_buyuseOpen);
        //BuyMaterialTab.SetActive(b_buymaterialOpen);

        ItemTab.SetActive(b_itemOpen);
        

        if (b_buyequipmentOpen)
            BuyEquipmentButton.GetComponent<Image>().color = ButtonActiveColour;
        else
            BuyEquipmentButton.GetComponent<Image>().color = ButtonInactiveColour;

        if (b_buyuseOpen)
            BuyUseButton.GetComponent<Image>().color = ButtonActiveColour;
        else
            BuyUseButton.GetComponent<Image>().color = ButtonInactiveColour;

        if (b_buymaterialOpen)
            BuyMaterialButton.GetComponent<Image>().color = ButtonActiveColour;
        else
            BuyMaterialButton.GetComponent<Image>().color = ButtonInactiveColour;


    }

    //buy
    public void Buy_Open()
    {
        Debug.Log("buy_Opened");
        b_buyOpen = true;
        b_sellOpen = false;
        b_repairOpen = false;
        b_rebuyOpen = false;
        
    }
    public void Buy_Close()
    {
        Debug.Log("buy_Closed");
        b_buyOpen = false;
    }

    //sell
    public void Sell_Open()
    {
        Debug.Log("sell_Opened");
        b_buyOpen = false;
        b_sellOpen = true;
        b_repairOpen = false;
        b_rebuyOpen = false;

    }
    public void Sell_Close()
    {
        Debug.Log("sell_Closed");
        b_sellOpen = false;
    }

    //repair
    public void Repair_Open()
    {
        Debug.Log("repair_Opened");
        b_buyOpen = false;
        b_sellOpen = false;
        b_repairOpen = true;
        b_rebuyOpen = false;

    }
    public void Repair_Close()
    {
        Debug.Log("repair_Closed");
        b_repairOpen = false;
    }

    //rebuy
    public void Rebuy_Open()
    {
        Debug.Log("rebuy_Opened");
        b_buyOpen = false;
        b_sellOpen = false;
        b_repairOpen = false;
        b_rebuyOpen = true;

    }
    public void Rebuy_Close()
    {
        Debug.Log("rebuy_Closed");
        b_rebuyOpen = false;
    }

    /// <summary>
    /// 
    /// </summary>
    //buy equipment
    public void Buyequipment_Open()
    {
        Debug.Log("buyequiment_Opened");
        b_buyequipmentOpen = true;
        b_buyuseOpen = false;
        b_buymaterialOpen = false;

    }
    public void Buyequipment_Close()
    {
        Debug.Log("buyequiment_Closed");
        b_buyequipmentOpen = false;
    }

    //buy use
    public void Buyuse_Open()
    {
        Debug.Log("buyuse_Open");
        b_buyequipmentOpen = false;
        b_buyuseOpen = true;
        b_buymaterialOpen = false;

    }
    public void Buyuse_Close()
    {
        Debug.Log("buyuse_Close");
        b_buyuseOpen = false;
    }

    //buy material
    public void Buymaterial_Open()
    {
        Debug.Log("buymaterial_Open");
        b_buyequipmentOpen = false;
        b_buyuseOpen = false;
        b_buymaterialOpen = true;

    }
    public void Buymaterial_Close()
    {
        Debug.Log("buymaterial_Close");
        b_buymaterialOpen = false;
    }

    //buy item1
    public void Buyitem_Open()
    {
        Debug.Log("buyitem1_Open");
        b_itemOpen = true;
        Debug.Log(b_itemOpen);
    }
    public void Buyitem_Close()
    {
        Debug.Log("buyitem1_close");
        b_itemOpen = false;
    }
}
