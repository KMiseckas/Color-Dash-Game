using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HighScoreShow : MonoBehaviour 
{

	Text text;

	void Start()
	{
		text = GetComponent<Text> ();

		text.text = "Easy: " + PlayerPrefs.GetInt ("Highscore_Easy") + "\n" + "\n" + "Normal: "
			+ PlayerPrefs.GetInt ("Highscore_Normal") + "\n" + "\n" + "Hard: " + PlayerPrefs.GetInt ("Highscore_Hard");
	}

}
