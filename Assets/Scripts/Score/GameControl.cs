using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour {
	public int score;
	public string playerName;

	public static GameControl Instance;

	public void Awake()
	{
		if (Instance == null) {
			DontDestroyOnLoad (gameObject);
			Instance = this;
		} else {
			Destroy (gameObject);
		}

	}

	public void setScore(int s)
	{
		score = s;
	}

	public int getScore()
	{
		return score;
	}

	public void increaseScore(int s)
	{
		score += s;
	}

	public void increaseScore()
	{
		increaseScore (1);
	}

	public void setName(string n)
	{
		playerName = n;
	}

	public string getName()
	{
		return playerName;
	}

}
