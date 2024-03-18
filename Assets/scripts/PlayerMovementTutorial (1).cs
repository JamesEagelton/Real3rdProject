using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovementTutorial : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed;
    public Animator beamlocation;
    public float groundDrag;

    public float jumpForce;
    public float jumpCooldown;
    public float beamCooldown;
    public float airMultiplier;
    bool readyToJump;

    [HideInInspector] public float walkSpeed;
    [HideInInspector] public float sprintSpeed;

    [Header("Keybinds")]
    public KeyCode jumpKey = KeyCode.Space;

    [Header("Ground Check")]
    public float playerHeight;
    public LayerMask whatIsGround;
    bool grounded;
    bool beamready;

    public Transform orientation;

    float horizontalInput;
    float verticalInput;

    Vector3 moveDirection;
    public GameObject beam;
    public GameObject cross;

    Rigidbody rb;

    public Camera  maincamera;

    public AudioSource beamnoise;
    public scorescript score;
    

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;

        readyToJump = true;
        beamready = true;
    }

    private void Update()
    {
        // ground check
        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.3f, whatIsGround);

        MyInput();
        SpeedControl();

        // handle drag
        if (grounded)
            rb.drag = groundDrag;
        else
            rb.drag = 0;

        this.transform.rotation = Quaternion.Euler(0, Camera.main.transform.eulerAngles.y, 0);

        
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }


    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == ("enemy")) 
        {
            score.playerhealth = score.playerhealth - 1;
        }
    
    }

    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        // when to jump
        if(Input.GetKey(jumpKey) && readyToJump && grounded)
        {
            readyToJump = false;

            Jump();

            Invoke(nameof(ResetJump), jumpCooldown);
        }

        if(Input.GetMouseButtonDown(0) && beamready) 
        { 
            beamready = false;
            beamlocation.SetTrigger("Fire");

            Beam();

            Invoke(nameof(ResetBeam), beamCooldown);
        
        }
    }

    private void MovePlayer()
    {
        // calculate movement direction
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;

        // on ground
        if(grounded)
            rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);

        // in air
        else if(!grounded)
            rb.AddForce(moveDirection.normalized * moveSpeed * 10f * airMultiplier, ForceMode.Force);
    }

    private void SpeedControl()
    {
        Vector3 flatVel = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        // limit velocity if needed
        if(flatVel.magnitude > moveSpeed)
        {
            Vector3 limitedVel = flatVel.normalized * moveSpeed;
            rb.velocity = new Vector3(limitedVel.x, rb.velocity.y, limitedVel.z);
        }
    }

    private void Jump()
    {
        // reset y velocity
        rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
    }
    private void ResetJump()
    {
        readyToJump = true;
    }

    private void ResetBeam() 
    { 
        beamready = true;
    }

    private void Beam()
    {
        
        
        Ray ray = maincamera.ViewportPointToRay(new Vector3(.5f, .5f, 0f));
        RaycastHit hit;
        beamnoise.Stop();
        beamnoise.Play();



        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log("Im looking at " + hit.transform.name);
            if (hit.transform.CompareTag("enemy"))
            {
                enemycontroller enemycont = hit.transform.parent.GetComponent<enemycontroller>();
                if (enemycont != null)
                {
                    enemycont.takedamage();
                }
                GetComponent<AudioSource>().Stop();
                GetComponent<AudioSource>().Play();


            }
        }
        else
        {
            Debug.Log("NOTHING");
        }

    }
}