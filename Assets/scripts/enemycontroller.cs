using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemycontroller : MonoBehaviour
{

    public int health = 1;
    public GameObject hiteffect;
    public int total;
    public int count = 0;
    public int value;
    public GameObject effectpoint;
    public UIEvent uIEvent;
    


    void Start()
    {
        
        
        
    }


    void Update()
    {
        
        

        
    }

    public void takedamage() 
    {

        health--;
        if (health <= 0) 
        {
            Destroy(gameObject);
            Instantiate(hiteffect, effectpoint.transform.position, effectpoint.transform.rotation);
            uIEvent.Appear();
            



        }
    
    }
    private void OnDestroy()
    {
        count = count + value;
    }
}   


