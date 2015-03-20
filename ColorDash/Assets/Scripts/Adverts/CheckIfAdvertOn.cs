using UnityEngine;
using UnityEngine.Advertisements;
using System.Collections;

public class CheckIfAdvertOn : MonoBehaviour 
{

	public static int gameOverCount = 0;

	void Awake()
	{
		if (Advertisement.isSupported) 
		{
			Advertisement.allowPrecache = true;
			Advertisement.Initialize ("27128",false);
		} else 
		{
			Debug.Log("Platform not supported");
		}
	}

	void Start()
	{
		if(gameOverCount == 3)
		{
			Advertisement.Show(null, new ShowOptions {
				pause = true,
				resultCallback = result => {
				Debug.Log(result.ToString());
				}
			});
		}
	}

}
