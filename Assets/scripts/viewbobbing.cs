using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class viewbobbing : MonoBehaviour
{
    public float maxheight;
    public float currentheight;

    bool shooting = false;


    // Update is called once per frame
    void Update()
    {
        Vector3 inputVector = new Vector3(Input.GetAxisRaw("Vertical"), 0f, Input.GetAxisRaw("Horizontal"));

        if (Input.GetMouseButtonDown(0)) 
        { 
            
        }
       
        
    }   
}
