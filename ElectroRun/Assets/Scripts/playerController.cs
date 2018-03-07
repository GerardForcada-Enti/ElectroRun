using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {
    public float speed;
    public Rigidbody2D myRB;
    Vector2 direction;

	// Use this for initialization
	void Start () {
        myRB = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        /*
        if (Input.GetKey(KeyCode.RightArrow))
        {
            direction = new Vector2(1, 0);
            myRB.AddForce(direction * speed);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            direction = new Vector2(0, 20);
            myRB.AddForce(direction * speed);
        }
        */
    }
}
