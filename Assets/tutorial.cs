using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class tutorial : MonoBehaviour
{
    public int tutorialPart = 1;
    public Text clickTutorialText;
    public Text scoreTutorialText;
    public float textcooldown;


    // Update is called once per frame

    void  scoreTextCoolDown()
    { 
    
      scoreTutorialText.text = "IF THE SCORE REACHES 0 OR 1000, THEN 1 HEART WILL BE REMOVED";

    }
    
    
    
    void Update()
    {

        switch (tutorialPart)
        { 
            case 1:
                clickTutorialText.text = "CLICK TO SHOOT";
                if (Input.GetMouseButtonDown(0)) 
                { 
                    tutorialPart = 2;
                }
                break;
            case 2:
                clickTutorialText.text = "";
              
                
                scoreTutorialText.text = "AS THE GAME PROGRESSES, THE SCORE WILL GO DOWN";

                Invoke(scoreTextCoolDown(), textcooldown);
              
                  
               
                
                break;



            default:
                break;
        }
    
    
         
        
        
    
    }
}
