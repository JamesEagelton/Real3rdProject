using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIEvent : MonoBehaviour
{
    [Header("james thing")]
    public Image bloodImage;
    public float fadeInTime = 2.0f;
    public float waitTime = 0.5f;
    public float fadeOutTime = 2.0f;
    public float alphaMax;

    private void Start()
    {
        
    }


    void Update()
    {
        
    }

    

    public void SetInvisible()
    {
        if (bloodImage != null)
        {
            Color textColor = bloodImage.color;
            textColor.a = 0.0f; // Set alpha to 0 for full transparency
            bloodImage.color = textColor;
        }
        // Debug.Log("Set text invisible");
    }

    public void Appear()
    {
        StartCoroutine(FadeInAndOutCoroutine(fadeInTime, fadeOutTime));
        Debug.Log("Text appears and disappears");
        
    }

    IEnumerator FadeInAndOutCoroutine(float fadeInTime, float fadeOutTime)
    {
        // Fade in
        yield return StartCoroutine(FadeInTextCoroutine(fadeInTime));

        // Wait for a short duration (you can adjust this as needed)
        yield return new WaitForSeconds(waitTime);

        // Fade out
        yield return StartCoroutine(FadeOutTextCoroutine(fadeOutTime));
        // Debug.Log("Text disappears");
    }

    IEnumerator FadeInTextCoroutine(float fadeInTime)
    {
        // Debug.Log("Start fade in coroutine");
        Color originalColor = bloodImage.color;
        Color targetColor = new Color(originalColor.r, originalColor.g, originalColor.b, alphaMax);

        float elapsedTime = 0.0f;

        while (elapsedTime < fadeInTime)
        {
            bloodImage.color = Color.Lerp(originalColor, targetColor, elapsedTime / fadeInTime);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Ensure the text is fully visible at the end of the coroutine
        bloodImage.color = targetColor;
    }

    IEnumerator FadeOutTextCoroutine(float fadeOutTime)
    {
        // Debug.Log("Start fade out coroutine");
        Color originalColor = bloodImage.color;
        Color targetColor = new Color(originalColor.r, originalColor.g, originalColor.b, 0.0f);

        float elapsedTime = 0.0f;

        while (elapsedTime < fadeOutTime)
        {
            bloodImage.color = Color.Lerp(originalColor, targetColor, elapsedTime / fadeOutTime);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Ensure the text is fully transparent at the end of the coroutine
        bloodImage.color = targetColor;
    }

}


