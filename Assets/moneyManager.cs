using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moneyManager : MonoBehaviour
{
    public float money;
    public UIManager UIManager;
    private void Start()
    {
        UIManager.UpdateMoneyText(money.ToString());
    }
    public bool UpdateMoney(float amount)
    {
        if(money + amount < 0)
        {
            Debug.Log("No te alcanza");
            return false;
        }
       
        
            money += amount;
        UIManager.UpdateMoneyText(money.ToString());
        return true;
        
        
    }

}
