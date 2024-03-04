using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartSpin : MonoBehaviour
{
    public float rotationSpeed;
    

    // Update is called once per frame
    void Update()
    {
        transform.localRotation *= Quaternion.AngleAxis(rotationSpeed * Time.deltaTime, Vector3.back);
    }
}
