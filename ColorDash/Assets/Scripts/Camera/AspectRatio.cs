using UnityEngine;
using System.Collections;

public class AspectRatio : MonoBehaviour 
{

	void Start()
	{
		//Keep aspect ratio the same when on different resolution
		Camera.main.aspect = 16f / 9f;
	}

}
