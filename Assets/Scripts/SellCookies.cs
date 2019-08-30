using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class SellCookies : MonoBehaviour
{
    public GameObject textBox;
    public Gameobject StatusBox;

    public void ClickTheBotton()
    {
        if (GlobleCookie.CookieCount == 0)
        {

            StatusBox.Getcomponent<text>().text = "Not Enough Cookie to Sell.";
            StatusBox.GetComponent<animation>().Play("StatusAnimation");
        }
        else
        {
            GlobleCockie.CookieCount -= 1;
            GlobleCash.CashCount += 1;

        }

        

    }
}
