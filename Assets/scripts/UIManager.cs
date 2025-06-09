using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI txtMoney;
    public TextMeshProUGUI txtVida;
    void Start()
    {
        txtMoney.text = "$0";
    
    }
    public void UpdateMoneyText(string moneyAmount)
    {
        txtMoney.text = "$" + moneyAmount;
    }
    public void updateHealthText(string healthPoints)
    {
        txtVida.text = "HP" + healthPoints;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
