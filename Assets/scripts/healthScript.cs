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
    public AudioSource playerDamageNoise;
    int canPlayNoise = 1;
    

    private void Start()
    {
        
    }

    void takenDamage() 
    { 
    
        playerDamageNoise.Play();
    
    }



    // Update is called once per frame
    void Update()
    {
        switch (scoreScript.playerhealth) 
        { 
            case 0:
                Destroy(heart1);
                if (canPlayNoise == 3)
                {
                    takenDamage();
                    canPlayNoise = canPlayNoise + 1;
                }



                break;
            case 1:
                Destroy(heart2);
                animator[0].SetInteger("health", 1);
                if (canPlayNoise == 2)
                {
                    takenDamage();
                    canPlayNoise = canPlayNoise + 1;
                }
                break;
            
            case 2:
                Destroy(heart3);
                animator[1].SetInteger("health", 2);
                animator[0].SetInteger("health", 2);
                if (canPlayNoise == 1) 
                { 
                    takenDamage();
                    canPlayNoise = canPlayNoise + 1;
                }
                break;

            default:
                break;




        }
    }
}
