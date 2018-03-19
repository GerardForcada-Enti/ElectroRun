using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {
    public float speed = 200f;
    public float jumpSpeed = 10f;
    private Rigidbody2D rb;
    private Transform trans;
    Vector2 movement;
    public Transform end;
    public Transform start;
    bool isGrounded;

	void Start () {
        rb = GetComponent<Rigidbody2D>();
        trans = GetComponent<Transform>();
	}

    void FixedUpdate () {
        float horizontalAxisValue = Input.GetAxis("Horizontal");
        float verticalAxisValue = Input.GetAxis("Vertical");

        if (horizontalAxisValue > 0)
        {
            if (rb.velocity.x < 10.0)
            {
                rb.AddForce(Vector2.right * speed);
            }
        }

        if (horizontalAxisValue < 0)
        {
            if (rb.velocity.x > -10.0)
            {
                rb.AddForce(Vector2.left * speed);
            }
        }

        if (verticalAxisValue > 0)
        {
            Debug.DrawLine(start.position, end.position);
            isGrounded = Physics2D.Linecast(start.position, end.position);
            if (isGrounded == true)
            {
                rb.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Impulse);
            }
        }
    }  
    
/*
    void fixedUpdate() {
        if (true)
        {

        }
    }
    */
}
