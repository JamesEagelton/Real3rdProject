
using UnityEngine;

public class HeartExplode : MonoBehaviour
{
    // Start is called before the first frame update
        public GameObject bloodEffect;
    public AudioSource heartsound;
    
    public  void playSound() 
    { 
        heartsound.Play();
    }

    private void Start()
    {
        heartsound.Play();
    }
    private void OnDestroy()
    {
        Instantiate(bloodEffect, this.transform.position, this.transform.rotation);
    }
}
