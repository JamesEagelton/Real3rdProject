using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class billboard : MonoBehaviour
{

    public Transform camTransform;



    void Update()

    {

        transform.rotation = camTransform.rotation;

    }

}

