using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballScript : MonoBehaviour
{
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize any variables or setup code here if needed
    }

    // Update is called once per frame
    void Update()
    {
        // Update code here, if needed
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Handle collision logic, if needed
        print("Ouch");
    }

    internal void ImThrowingYou(PlayerController playerController)
    {
        // Set the initial position of the snowball based on the player's position and direction
        transform.position = playerController.transform.position + 2 * Vector3.up + 3 * playerController.transform.forward;

        // Get the Rigidbody component
        rb = GetComponent<Rigidbody>();

        // Set the initial velocity for the snowball
        rb.velocity = 3 * (2 * Vector3.up + 3 * playerController.transform.forward);
    }
}
