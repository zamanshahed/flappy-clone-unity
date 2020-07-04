using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

    Rigidbody2D rb;
    public float speed;

    int angle;
    int maxAngle = 20;
    int minAngle = -90;


	void Start () {
        rb = GetComponent<Rigidbody2D>();	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.zero;
            //Jump
            rb.velocity = new Vector2(rb.velocity.x, speed);
        }
        //if (Input.GetMouseButtonUp(0))
        //{
        //    rb.velocity = new Vector2(rb.velocity.x, speed);
        //}
        BirdRotation();
      
	}
    void BirdRotation()
    {
        if (rb.velocity.y > 0)
        {
            if (angle <= maxAngle)
            {
                angle = angle + 4;
            }
        }
        else if (rb.velocity.y < 1.3f)
        {
            if (angle >= minAngle)
            {
                angle = angle - 3;
            }
        }
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
