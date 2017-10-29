using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneCollider : MonoBehaviour {
    private Rigidbody2D rigid;

	// Use this for initialization
	void Start () {
        rigid = GetComponent<Rigidbody2D>();
	}
	
	void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("LowTireInfo")) {
            SceneManager.LoadScene(other.tag);
        } 
    }
}
