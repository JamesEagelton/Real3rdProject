using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthScript : MonoBehaviour
{
    // Start is called before the first frame update

    public scorescript scoreScript;


    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public  Animator[] animator;
    
    

    private void Start()
    {
        
    }





    // Update is called once per frame
    void Update()
    {
        switch (scoreScript.playerhealth) 
        { 
            case 0:
                Destroy(heart1);
                
               
                break;
            case 1:
                Destroy(heart2);
                animator[0].SetInteger("health", 1);
                break;
            case 2:
                Destroy(heart3);
                animator[1].SetInteger("health", 2);
                animator[0].SetInteger("health", 2);
                break;

            default:
                break;




        }
    }
}
