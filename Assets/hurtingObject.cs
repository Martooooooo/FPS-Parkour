using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hurtingObject : MonoBehaviour
{
    public int damagePoints;
    public healthManager healthManager;
    // Start is called before the first frame update
    void Start()
    {
        healthManager = FindObjectOfType<healthManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            healthManager.UpdateHealth(-damagePoints);

         
        }
    }

}
