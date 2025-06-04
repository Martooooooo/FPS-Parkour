﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI txtMoney;
    void Start()
    {
        txtMoney.text = "$0";
    
    }
    public void UpdateMoneyText(string moneyAmount)
    {
        txtMoney.text = "$" + moneyAmount;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
