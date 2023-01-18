using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    public float jumpAmount = 10;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

   
    void Update()
    {
        float horizon = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 vector = new Vector3(horizon, 0, vertical);
        rb.AddForce(vector * speed);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, 10, 0) * jumpAmount * jumpAmount);
        }


        if (Input.GetKey(KeyCode.LeftShift))
        {
            rb.AddForce(vector * speed * speed);
        }






    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Respawn")
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;

            rb.Sleep();
        }
    }



}
