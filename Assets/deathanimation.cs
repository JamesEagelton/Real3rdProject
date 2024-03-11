using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathanimation : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    public UIEvent UiEvent;
    public GameObject canvas;
    public GameObject deathcanvas;
    public scorescript health;
    public int times = 0;
    
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (health.playerhealth == 0 && times == 0 ) 
        { 
            deathcanvas.SetActive(true);
            canvas.SetActive(false);
            animator.SetBool("isDead", true);
            UiEvent.Appear();
            times ++;
        }
    
    }
}
