using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class democharacter : MonoBehaviour
{
    public float acceleration = 150f;
    public float maxSpeed = 3f;
    public float jumpForce = 10f;
    public float jumpBoost = 5f;

    public bool isGrounded;
    

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontalAxis = Input.GetAxis("Horizontal");
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.velocity += horizontalAxis * Vector3.right * Time.deltaTime * acceleration;

        Collider col = GetComponent<Collider>();
        float castAmount = 0.03f; //col.bounds.extents.y + 0.03f;

       isGrounded = Physics.Raycast(transform.position, Vector3.down, castAmount);

       rb.velocity = new Vector3(Mathf.Clamp(rb.velocity.x, -maxSpeed, maxSpeed), rb.velocity.y, rb.velocity.z);
        
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpBoost, ForceMode.Force);
        }

        Color lineColor = (isGrounded) ? Color.green : Color.red;
        Debug.DrawLine(transform.position, transform.position + Vector3.down * castAmount, lineColor,0f, false);

    }
}
