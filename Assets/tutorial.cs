using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class tutorial : MonoBehaviour
{

    public string[] texts;
    public float clickCooldown = 1;
    public Text text;

    private int currentIndex = 0;
    private bool cooldown = true;
    private bool dialogueBegun = true;

    void Start()
    {

    }


    void Update()
    {
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
