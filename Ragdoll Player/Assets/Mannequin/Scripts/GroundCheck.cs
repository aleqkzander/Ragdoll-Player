using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    private PlayerController controller;

    private void Awake()
    {
        controller = GameObject.FindObjectOfType<PlayerController>().GetComponent<PlayerController>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        controller.isGrounded = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        controller.isGrounded = false;
    }
}
