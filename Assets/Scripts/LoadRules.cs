using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadRules : MonoBehaviour {

	public void OpenRules() {
		SceneManager.LoadScene("Rules");
	}
}
