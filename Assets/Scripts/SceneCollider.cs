using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneCollider : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("LowTireInfo")) {
            SceneManager.LoadScene(other.tag);
        }

        if (other.CompareTag("ChangeTireInfo")) {
            SceneManager.LoadScene(other.tag);
        }

        if (other.CompareTag("StuckInSnowScene"))
        {
            SceneManager.LoadScene(other.tag);
        }
		if (other.CompareTag("Accident"))
		{
			SceneManager.LoadScene("CarAccident");
		}
    }
}
