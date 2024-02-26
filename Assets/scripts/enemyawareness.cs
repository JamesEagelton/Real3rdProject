using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyawareness : MonoBehaviour
{
    public bool isAggro = false;


    private void Update()
    {
        
        

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") 
        { 
        
            isAggro = true;
        
        }
        
    }

    
}
