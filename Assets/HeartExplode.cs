using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartExplode : MonoBehaviour
{
    // Start is called before the first frame update
        public GameObject bloodEffect;
    private void OnDestroy()
    {
        Instantiate(bloodEffect, this.transform.position, this.transform.rotation);
    }
}
