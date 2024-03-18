
using UnityEngine;
using UnityEngine.SceneManagement;

public class deathscene : MonoBehaviour
{
    public int sceneNumber;
    
   public  void sceneload()
    {
        SceneManager.LoadScene(sceneNumber);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
