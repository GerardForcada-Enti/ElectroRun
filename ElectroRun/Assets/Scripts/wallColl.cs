using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallColl : MonoBehaviour {
    public Transform cam;
    private Transform playerTrans;
	// Use this for initialization
	void Start () {
        playerTrans = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "wall")
        {
            //Rotar cam
            cam.transform.eulerAngles = transform.eulerAngles - new Vector3(0, 0, 90);
            playerTrans.transform.eulerAngles = transform.eulerAngles - new Vector3(0,0,90);
            //Invertir grav
            Physics2D.gravity = new Vector2(-9, 0);
        }
    }
}
