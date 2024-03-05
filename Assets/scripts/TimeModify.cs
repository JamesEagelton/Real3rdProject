using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TimeModify : MonoBehaviour
{
    // Start is called before the first frame update

    public float starttime = 1;
    public float decay;
    public scorescript score;
    public GameObject canvas;
    bool death = false;
    public GameObject handscamera;
    public GameObject deathscreen;
    public Animator deathanimation;
    

    
    public void SetTimeScale(float Scale) 
    { 
        Time.timeScale = Scale;
        Time.fixedDeltaTime = Scale * 0.02f;
    }
    
    
    
    

    // Update is called once per frame
    void Update()
    {
        
        
        
        if (score.playerhealth <= 0) 
        {
            death = true;
            
           
        
        }




        if (death == true)
        {
            canvas.SetActive(false);
            handscamera.SetActive(false);
            deathanimation.SetBool("isdead", true);
            starttime = Mathf.Lerp(starttime, 0f, 0.1f);
            SetTimeScale(starttime);
            deathscreen.SetActive(true);
            
        }

        if(starttime <= 0f) 
        {
            
        }
    }
}
