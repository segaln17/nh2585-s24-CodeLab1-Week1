using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class WASD : MonoBehaviour
{
    //declare and assign a maximum velocity so it doesn't exceed that amount
    public float maxVelocity = 10;
    
    //declare and assign a force amount --> amount that it is propelled
    public float forceAmt = 20;

    //declare rigidbody variable
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        //get access to the rigidbody on the GameObject this script is assigned to
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //move the object forward by forceAmt each time "W" is pressed
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(forceAmt * Vector3.forward);
        }

        //move the object backwards by forceAmt each time "S" is pressed
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(forceAmt * Vector3.back);
        }

        //move the object left by forceAmt each time "A" is pressed
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(forceAmt * Vector3.left);
        }

        //move the object right by forceAmt each time "D" is pressed
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(forceAmt * Vector3.right);
        }
        
        //normalize the vector in order to cap the velocity at maxVelocity
        if (rb.velocity.magnitude > maxVelocity) //if the speed exceeds maxVelocity amount
        {
            Vector3 newVelocity = rb.velocity.normalized; //normalize the velocity and set it equal to a new variable
            newVelocity *= maxVelocity;
            rb.velocity = newVelocity; //reset the velocity of the object to the normalized velocity
        }
    }
}
