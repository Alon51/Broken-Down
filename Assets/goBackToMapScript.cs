using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class goBackToMapScript : MonoBehaviour {

	public void onClick(){
		
		SceneManager.LoadScene("Map");
	}
}
