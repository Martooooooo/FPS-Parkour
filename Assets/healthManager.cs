using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthManager : MonoBehaviour
{
    public int healthPoints;
    public UIManager uiManager;
    // Start is called before the first frame update
    void Start()
    {
        uiManager.updateHealthText(healthPoints.ToString());  
    }

    public void UpdateHealth(int damageAmount)
    {
        if(healthPoints+ damageAmount<= 0)
        {
            Debug.Log("Game Over");
            healthPoints = 0;
            Debug.Log(healthPoints);

            return;
        }
        uiManager.updateHealthText(healthPoints.ToString());
    }
}
