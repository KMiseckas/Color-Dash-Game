using UnityEngine;
using System.Collections;

public class GameIntro : MonoBehaviour
{
	public AnimationClip introAnim;
	public static bool firstTimeOn = false;

	IEnumerator Start()
	{
		//Waits for introduction animation to finish playing to load new scene
		yield return new WaitForSeconds (introAnim.length + 0.3f);
		Application.LoadLevel ("MainMenu");
	}

}
