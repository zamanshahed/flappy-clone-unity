using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

    Rigidbody2D rb;
    public float speed;

	void Start () {
        rb = GetComponent<Rigidbody2D>();	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
        {
            //Jump
            rb.velocity = new Vector2(rb.velocity.x, speed);
        }
        if (Input.GetMouseButtonUp(0))
        {
            rb.velocity = new Vector2(rb.velocity.x, speed);
        }
	}
}
