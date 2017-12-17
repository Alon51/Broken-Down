using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Score : MonoBehaviour {
	//public int score = 0;
	public Text scoreTxt;

	// Use this for initialization
	void Start () {
		scoreTxt.text = "Saved: $" + GameControl.Instance.getScore ();
	}
	
	// Update is called once per frame
	void Update () {
		scoreTxt.text = "Saved: $" + GameControl.Instance.getScore ();
	}

	public void IncreaseScore(int addend){
		GameControl.Instance.increaseScore (addend);
		//score += addend;
		scoreTxt.text = "Saved: $" + GameControl.Instance.getScore();
	}

	public void IncreaseScore (){
		IncreaseScore (1);
	}
}

