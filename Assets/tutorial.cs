using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class tutorial : MonoBehaviour
{
<<<<<<< HEAD

    public string[] texts;
    public float clickCooldown = 1;
    public Text text;
=======
    public int tutorialPart = 1;
    public Text clickTutorialText;
    
    public float textcooldown;
    public bool isready = true;

    
    public scorescript scorescript;
>>>>>>> 3acfde25a45229d53a7cad45975aa0b9dfb0752e

    private int currentIndex = 0;
    private bool cooldown = true;
    private bool dialogueBegun = true;

<<<<<<< HEAD
    void Start()
    {
=======
>>>>>>> 3acfde25a45229d53a7cad45975aa0b9dfb0752e


    void skiptext() 
    {
        tutorialPart = tutorialPart + 1;
        isready = true;
    }


    void Update()
    {
<<<<<<< HEAD
        if (cooldown && dialogueBegun)
        {
            if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return))
            {
                CooldownStart();
                if (currentIndex < texts.Length)
                {
                    Dialogue();
                    if (currentIndex >= texts.Length)
                    {
                        Debug.Log("Dialogue 1 end");
                    }
                }
            }
=======
        

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
>>>>>>> 3acfde25a45229d53a7cad45975aa0b9dfb0752e
        }
    }
    private void Dialogue()
    {
        text.text = texts[currentIndex];
        Debug.Log("Im GOING TO HANG MYSELF");
        currentIndex++;
    }

    void CooldownStart()
    {
        StartCoroutine(CooldownCoroutine());
    }
    IEnumerator CooldownCoroutine()
    {
        cooldown = false;
        yield return new WaitForSeconds(clickCooldown);
        cooldown = true;
    }
}
