
using UnityEngine;

public class cameramover : MonoBehaviour
{
    public float sensX;
    public Transform orientation;
    public GameObject cameraholder;
    public GameObject mainCam;
    float mouseX;
    float mouseY;
    public float sensY;
    float yRotation;
    float xRotation;



    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible= false;
    }


    void Update()
    {
        
        mainCam.transform.position= cameraholder.transform.position;
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;
        yRotation += mouseX;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90F, 90F);
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation  = Quaternion.Euler(0, yRotation, 0);



    }
}
