using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EndLevelUIScore : MonoBehaviour 
{
	public GameObject player;
	public GameObject text2;

	Text text;
	Score score;

	void Start()
	{
		score = player.GetComponent<Score> ();
		text = text2.GetComponent<Text> ();

		text.text = "GAME OVER";

		text = GetComponent<Text> ();

		//Show end level text
		text.text = "Current: " + score.ThisLevelScore + "\n" + "High Score: " + PlayerPrefs.GetInt ("Highscore_" + Difficulty.difficulty);
	}

}
