/*using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    //public Rigidbody theRB;
    /*public float jumpForce;
    public CharacterController controller;
    Animator myAnimator;
    private Vector3 moveDirection;
    public float gravityScale;

    public GameObject snowballCloneTemplate;
    float currentSpeed, walkingSpeed = 5, runningSpeed = 40, jumpForce=10;
    private float turningSpeed = 180;
    bool hasJumped = false;
    Rigidbody theRB;
    Animator myAnimator;
    // Start is called before the first frame update
    void Start()
    {
        currentSpeed = walkingSpeed;
        myAnimator = GetComponent<Animator>();
        theRB = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //theRB.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, theRB.velocity.y, Input.GetAxis("Vertical") * moveSpeed);

        /*if(Input.GetButtonDown("Jump"))
        {
            theRB.velocity = new Vector3(theRB.velocity.x, jumpForce, theRB.velocity.z);
        }*/

//moveDirection = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, moveDirection.y, Input.GetAxis("Vertical") * moveSpeed);
/*float yStore = moveDirection.y;

moveDirection = (transform.forward * Input.GetAxis("Vertical")) + (transform.right * Input.GetAxis("Horizontal"));
moveDirection = moveDirection.normalized * moveSpeed;
moveDirection.y = yStore;

if (controller.isGrounded)
{
    moveDirection.y = 0f;
    if (Input.GetButtonDown("Jump"))
    {
        moveDirection.y = jumpForce;
    }
}
/*if (Input.GetKey(KeyCode.W))
{
    myAnimator.SetBool("isRunning", true);
    moveDirection.y = 0f;
}*/

//if (Input.GetButtonDown("Jump"))
/*{
    moveDirection.y = jumpForce;
}

moveDirection.y = moveDirection.y + (Physics.gravity.y * gravityScale * Time.deltaTime);
controller.Move(moveDirection * Time.deltaTime);
}
myAnimator.SetBool("is walking", false);
if (Input.GetKey(KeyCode.W))
{
    myAnimator.SetBool("is walking", true);
    transform.position += currentSpeed* transform.forward * Time.deltaTime;

}
if (Input.GetKey(KeyCode.S))

{
    myAnimator.SetBool("is walking", true);
    transform.position -= currentSpeed * transform.forward * Time.deltaTime;
}
if (Input.GetKey(KeyCode.D))
{
    transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);
}
if (Input.GetKey(KeyCode.A))
{
    transform.Rotate(Vector3.down, turningSpeed * Time.deltaTime);
}

if (Input.GetMouseButtonDown(0))
{
    Instantiate(snowballCloneTemplate);
    GameObject newGO = Instantiate(snowballCloneTemplate);
    SnowballScript mySnowball = newGO.GetComponent<SnowballScript>();

    mySnowball.ImThrowingYou(this);
}

if (Input.GetKeyDown(KeyCode.Space) && hasJumped==false)
{
    theRB.AddForce(Vector3.up*jumpForce, ForceMode.Impulse);
    hasJumped= true;

}

void onCollisionEnter(Collision collision){

    if (collision.gameObject.CompareTag("Ground")) { 

        hasJumped= false;

    }

}
}
}
//This script is from the YouTube chanell "gamesplusjames" */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public GameObject snowballCloneTemplate;
    float currentSpeed, walkingSpeed = 5, runningSpeed = 40, jumpForce = 8;
    private float turningSpeed = 180;
    bool hasJumped = false;
    Rigidbody theRB;
    Animator myAnimator;

    void Start()
    {
        currentSpeed = walkingSpeed;
        myAnimator = GetComponent<Animator>();
        theRB = GetComponent<Rigidbody>();
    }

    void Update()
    {
        myAnimator.SetBool("is walking", false);

        if (Input.GetKey(KeyCode.W))
        {
            myAnimator.SetBool("is walking", true);
            transform.position += currentSpeed * transform.forward * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            myAnimator.SetBool("is walking", true);
            transform.position -= currentSpeed * transform.forward * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down, turningSpeed * Time.deltaTime);
        }

        if (Input.GetMouseButtonDown(0))
        {
            // Instantiate the snowballCloneTemplate and get a reference to it.
            GameObject newGO = Instantiate(snowballCloneTemplate);

            // Ensure the newGO has the SnowballScript component.
            SnowballScript mySnowball = newGO.GetComponent<SnowballScript>();

            // Call a method in SnowballScript to handle the snowball behavior.
            mySnowball.ImThrowingYou(this);
        }

        if (Input.GetKeyDown(KeyCode.Space) && !hasJumped)
        {
            theRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            hasJumped = true;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            hasJumped = false;
        }
    }
}