using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour 
{

	private int thisLevelScore = 0;
	private int highScore;

	void Start()
	{
		//Set this highscore as saved highscore
		highScore = PlayerPrefs.GetInt ("Highscore_" + Difficulty.difficulty);
	}

	public int ThisLevelScore
	{
		get
		{
			return thisLevelScore;
		}

		set 
		{
			thisLevelScore = value;
		}
	}

	public void CheckHighScore(int score)
	{
		//Check if new highscore has been achieved on current difficulty
		if(thisLevelScore > highScore)
		{
			highScore = thisLevelScore;
			PlayerPrefs.SetInt("Highscore_" + Difficulty.difficulty,highScore);
		}
	}

}
