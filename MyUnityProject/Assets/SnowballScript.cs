using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballScript : MonoBehaviour
{
    Rigidbody rb;
    internal int check = 5;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        print("Ouch");
    }

    internal void ImThrowingYou(PlayerController playerController)
    {
        transform.position = playerController.transform.position + 2 * Vector3.up + 3 * playerController.transform.forward;
        rb = GetComponent<Rigidbody>();
        rb.velocity = 3 * (2 * Vector3.up + 3 * playerController.transform.forward);
    }
}

