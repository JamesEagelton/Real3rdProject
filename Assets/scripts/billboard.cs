using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class billboard : MonoBehaviour
{
    public Transform player;
    


    void Update()

    {
        this.transform.LookAt(player);
       
    }

}

