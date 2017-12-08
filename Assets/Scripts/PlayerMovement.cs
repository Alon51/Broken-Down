using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    private float speed = 2.0f;
    private float horizontalMovement;
    private float verticalMovement;
    private Rigidbody2D rigid;
    private new AudioSource audio;

    void Start () {
        rigid = GetComponent<Rigidbody2D>();
        audio = GetComponent<AudioSource>();
	}
	
	void Update () {
        horizontalMovement = Input.GetAxis("Horizontal");
        verticalMovement = Input.GetAxis("Vertical");
	}

    void FixedUpdate() {
        rigid.velocity = new Vector2(verticalMovement * speed, rigid.velocity.y);
        rigid.velocity = new Vector2(horizontalMovement * speed, rigid.velocity.x);

        // Rotates car to face left/right
        if(horizontalMovement > 0) {
            transform.eulerAngles = new Vector3(0, 0, 270);
        }
        if(horizontalMovement < 0) {
            transform.eulerAngles = new Vector3(0, 0, 90);
        }
        if(verticalMovement > 0) {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        if(verticalMovement < 0) {
            transform.eulerAngles = new Vector3(0, 0, 180);
        }

        // Plays engine sound
        if(horizontalMovement > 0 || horizontalMovement < 0 || verticalMovement > 0 || verticalMovement < 0) {
            if (!audio.isPlaying) {
                audio.Play();
            }
        }
        else {
            audio.Stop();
        }
    }
}
