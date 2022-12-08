using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody rb;
    [SerializeField] float movementSpeed;
    [SerializeField] float jumpForce;

    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask ground;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal"); // x-axis
        float verticalInput = Input.GetAxis("Vertical"); // z-axis

        rb.velocity = new Vector3(horizontalInput*movementSpeed, rb.velocity.y, verticalInput*movementSpeed);

        if (Input.GetButtonDown("Jump") && IsGrounded()) { //press only, button refers to input buttons in unity input manager
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
        }

        // if (Input.GetKeyDown("space")) { // press only
        //     rb.velocity = new Vector3(rb.velocity.x, 5, 0);
        // }
        
    }

    bool IsGrounded()
    {
        return Physics.CheckSphere(groundCheck.position, 0.1f, ground);
    }
}
