using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uifadein : MonoBehaviour
{
    private bool mFadaed = true;

    public float duration = 0.4f;

    public void fade() 
    { 
        var canvGroup = GetComponent<CanvasGroup>();

        StartCoroutine(DoFade(canvGroup, canvGroup.alpha, mFadaed ? 0 : 1));

        mFadaed = !mFadaed;
    }

    public IEnumerator DoFade(CanvasGroup canvGroup, float start, float end) 
    {
        float counter = 0f;

        while(counter< duration) 
        { 
        counter += Time.deltaTime;
            canvGroup.alpha = Mathf.Lerp(start, end, counter / duration);
            yield return null;
        }
        
    }



}
