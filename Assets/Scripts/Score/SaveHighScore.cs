using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveHighScore : MonoBehaviour {
	public Text highScores;
	const int HIGH_SCORES = 5;
	const string NAME_KEY = "highScoreName";
	const string SCORE_KEY = "highScore";

	// Use this for initialization
	void Start () {
		
		/*PlayerPrefs.SetInt (scoreKey, playerScore);
		PlayerPrefs.SetString (nameKey, playerName);*/
		InsertHighScores ();
		DisplayHighScores ();
	
	}

	void InsertHighScores()
	{
		string playerName = GameControl.Instance.getName ();
		int playerScore = GameControl.Instance.getScore ();


		for (int i = 0; i < HIGH_SCORES; i++) 
		{
			if (!PlayerPrefs.HasKey (SCORE_KEY + i)) {
				PlayerPrefs.SetString (NAME_KEY + i, playerName);
				PlayerPrefs.SetInt (SCORE_KEY + i, playerScore);
				return;
			}  
		

			int currentScore = PlayerPrefs.GetInt (SCORE_KEY + i);
			if (playerScore > currentScore) 
			{
				string currentName = PlayerPrefs.GetString (NAME_KEY + i);

				PlayerPrefs.SetInt (SCORE_KEY + i, playerScore);
				PlayerPrefs.SetString (NAME_KEY + i, playerName);

				playerScore = currentScore;
				playerName = currentName;
			}
		
		}
	}

	void DisplayHighScores()
	{
		for (int i = 0; i < HIGH_SCORES; i++)
		{
			if (PlayerPrefs.HasKey (SCORE_KEY + i))
			{
				Debug.Log(PlayerPrefs.GetString(NAME_KEY +i) + ", " + PlayerPrefs.GetInt(SCORE_KEY + i));

			}
		}

		/*for (int i = 1; i < HIGH_SCORES; i++) {
			PlayerPrefs.DeleteKey (NAME_KEY + i);
			PlayerPrefs.DeleteKey (SCORE_KEY + i);
		}

		for (int i = 0; i < HIGH_SCORES; i++)
		{
			if (PlayerPrefs.HasKey (SCORE_KEY + i))
			{
				Debug.Log(PlayerPrefs.GetString(NAME_KEY +i) + ", " + PlayerPrefs.GetInt(SCORE_KEY + i));

			}
		}*/


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
