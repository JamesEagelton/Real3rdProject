using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class scorescript : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider scorebar;
   
    public float scoredecay;
    public int playerhealth = 3;
    public float originalscore;
    public UIEvent uIEvent;
   
    public Text scoretext;
    string scorestring;

    private void Start()
    {
        scorebar.value = originalscore;
    }

    void Update()
    {

        scorebar.value = scorebar.value - scoredecay;
        

        if (scorebar.value <= 0 || scorebar.value >= 1000) 
        {
            playerhealth--;
            scorebar.value = originalscore;
            uIEvent.Appear();
        }

        
        
        
        scorestring = scorebar.value.ToString();
        scoretext.text = scorestring;
    }
}

