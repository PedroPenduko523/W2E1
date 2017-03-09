using UnityEngine;
using System.Collections;

public class Playercontroller : MonoBehaviour {
    //Pbulic fields
    public float speed;

    //Private fields
    private Rigidbody2D rb;


	// Use this for initializing variables
	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
	}
	
	void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb.velocity = movement * speed;

        rb.position = new Vector2(Mathf.Clamp(rb.position.x, -7.0f , 7.0f));
        Mathf.Clamp(rb.position.y, -4.0f, 4.0f);
	}
}
