using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Vector3 = UnityEngine.Vector3;

public class BasicCharacterController2 : MonoBehaviour
{
    public float runForce = 50f;
    public float jumpImpulseForce = 20f;
    public float jumpSustainForce = 7.5f;
    public float maxHorizontalSpeed = 6f;
    public bool feetInContactWithGround;

    void Update()
    {
        Bounds bounds = GetComponent<Collider>().bounds;
        feetInContactWithGround = Physics.Raycast(transform.position, Vector3.down, bounds.extents.y + 0.1f);

        var axis = Input.GetAxis("Horizontal");
        
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.right * axis * runForce, ForceMode.Force);

        if (feetInContactWithGround && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpImpulseForce, ForceMode.Impulse);
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpSustainForce, ForceMode.Force);
        }

        float xVelocity = Mathf.Clamp(rb.velocity.x, -maxHorizontalSpeed, maxHorizontalSpeed);

        if (Mathf.Abs(axis) < 0.1f)
        {
            xVelocity *= 0.9f;
        }

        rb.velocity = new Vector3(xVelocity, rb.velocity.y, rb.velocity.z);
        
        float speed = rb.velocity.magnitude;
        Animator animator = GetComponent<Animator>();
        animator.SetFloat("Speed",speed);
        animator.SetBool("Jumping", !feetInContactWithGround);
    }
}
