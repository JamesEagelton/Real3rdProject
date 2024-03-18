using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemycontroller : MonoBehaviour
{

    public int health = 1;
    public GameObject hiteffect;
    public Spawner spawner;
    
   
    public GameObject effectpoint;
   
    public scorescript score;
    public float scoreadded;
    


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
            score.scorebar.value = score.scorebar.value + scoreadded;
            Destroy(gameObject);
            Instantiate(hiteffect, effectpoint.transform.position, effectpoint.transform.rotation);
            spawner.SpawnEnemy();
            spawner.SpawnEnemy();
            
            
            



        }
    
    }
   
}   


