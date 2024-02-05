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
    public Text couning21;
    public Text text;
    public int value;
    


    void Start()
    {
        string valuestring = value.ToString();
        text.text = valuestring;
    }


    void Update()
    {
        
        

        couning21.text = count + " / " + total;
    }

    public void takedamage() 
    {

        health--;
        if (health <= 0) 
        {
            Destroy(gameObject);
            Instantiate(hiteffect, transform.position, Quaternion.identity);
            



        }
    
    }
    private void OnDestroy()
    {
        count = count + value;
    }
}   


