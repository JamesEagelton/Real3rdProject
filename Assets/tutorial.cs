using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class tutorial : MonoBehaviour
{
    public int tutorialPart = 1;
    public Text clickTutorialText;
    
    public float textcooldown;
    public bool isready = true;

    
    public scorescript scorescript;

    // Update is called once per frame



    void skiptext() 
    {
        tutorialPart = tutorialPart + 1;
        isready = true;
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
                clickTutorialText.text = "AS THE GAME PROGRESSES, THE SCORE WILL GO DOWN";
                if (isready)
                {
                    isready = false;
                    Invoke("skiptext", 3);
                }
                    break;
            case 3:
                
                    clickTutorialText.text = "IF THE SCORE REACHES 0 OR 1000, THEN 1 HEART WILL BE REMOVED";

                if (isready) 
                { 
                    
                    isready = false;
                    Invoke("skiptext", 6);
                }
                
            break;
            case 4:
                clickTutorialText.text = "TO GAIN SCORE KILL ENEMIES";
                if (isready)
                {

                    isready = false;
                    Invoke("skiptext", 6);
                }


                break;
            case 5:
                clickTutorialText.text = "THE SCORE WILL NOW BEGIN TO DECREASE";
                if (isready)
                {

                    isready = false;
                    Invoke("skiptext", 6);
                }


                break; 
            
            case 6:

                clickTutorialText.text = "";
                scorescript.tutorialComplete = true;
                
                
            break;
            default:
                break;
        }
    
    
         
        
        
    
    }
}
