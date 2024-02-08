using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorescript : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider scorebar;
    public float score;
    public float scoredecay;
    public int playerhealth = 3;
    float originalscore;
    public UIEvent uIEvent;

    private void Start()
    {
      originalscore = score;
    }

    void Update()
    {
        scorebar.value = score;
        score = score - scoredecay;

        if (score < 0.2 || score > 0.8) 
        {
            playerhealth--;
            score = originalscore;
            uIEvent.Appear();
        }
    }
}
