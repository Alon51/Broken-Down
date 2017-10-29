using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    private float speed = 2.0f;
    private float horizontalMovement;
    private float verticalMovement;
    private Rigidbody2D rigid;
    private bool facingLeft = true;
    
	void Start () {
        rigid = GetComponent<Rigidbody2D>();
	}
	
	void Update () {
        horizontalMovement = Input.GetAxis("Horizontal");
        verticalMovement = Input.GetAxis("Vertical");
	}

    void FixedUpdate() {
        rigid.velocity = new Vector2(verticalMovement * speed, rigid.velocity.y);
        rigid.velocity = new Vector2(horizontalMovement * speed, rigid.velocity.x);

        // Rotates car to face left/right
        if(horizontalMovement > 0 && facingLeft || horizontalMovement < 0 && !facingLeft) {
            transform.localScale = new Vector2(transform.localScale.x, -transform.localScale.y);
            facingLeft = !facingLeft;
        }
        
    }
}
