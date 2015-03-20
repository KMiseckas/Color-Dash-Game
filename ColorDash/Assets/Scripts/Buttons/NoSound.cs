using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NoSound : MonoBehaviour 
{

	Text text;

	void Start()
	{
		//Get button text, so text can be changed on press of button
		text = GetComponent<Text> ();

		if(!AudioListener.pause)
		{
			text.text = "Sound: On";
		}
		else
		{
			text.text = "Sound: Off";
		}
	}

	public void SoundToggle()
	{
		//Togle sound On/Off and change text
		if(AudioListener.pause)
		{
			AudioListener.pause = false;
			text.text = "Sound: On";
		}
		else
		{
			AudioListener.pause = true;
			text.text = "Sound: Off";
		}
	}
}
