﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobleCookie : MonoBehaviour
{
    public static int CookieCount;
    public GameObject CookieDisplay;
    public int InternalCookie;
    private void Update()
    { InternalCookie = CookieCount;
        CookieDisplay.GetComponent<Text>().text = "Coockie : " + InternalCookie;
    }
}
