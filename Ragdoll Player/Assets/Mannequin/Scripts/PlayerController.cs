using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody hips;
    public float walkSpeed = 4f;
    public float jumpForce = 4f;
    public bool isGrounded;

    private void FixedUpdate()
    {
        hips.AddForce(Movement());
    }


    private Vector3 Movement()
    {
        Vector3 direction = Vector3.zero;

        if (!isGrounded)
        {
            direction = Vector3.zero;
            return direction;
        }

        else if (isGrounded && Input.GetButton("Jump"))
        {
            direction = new(0, jumpForce * 1000, 0);
            return direction;
        }

        else if (isGrounded)
        {
            direction = new(Input.GetAxis("Horizontal") * walkSpeed * 100, 0, Input.GetAxis("Vertical") * walkSpeed * 100);
        }

        return direction;
    }

}
