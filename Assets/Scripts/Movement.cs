using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController controller;
    private Vector3 direction;
    public float speed = 8;
    public float jumpForce = 10;
    public float gravity = -20;
    public Transform groundCheck;
    public LayerMask groundLayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hInput = Input.GetAxis("Horizontal");
        direction.z = hInput * speed;

        bool isGrounded = Physics.CheckSphere(groundCheck.position,0.2f, groundLayer);
        Debug.Log(isGrounded);
        direction.y += gravity * Time.deltaTime;

        if (isGrounded)
        {
            if (Input.GetButtonDown("Jump"))
                {
                    direction.y = jumpForce;
                }
        }

        

        controller.Move(direction * Time.deltaTime);
    }
}
