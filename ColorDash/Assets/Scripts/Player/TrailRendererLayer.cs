using UnityEngine;
using System.Collections;

public class TrailRendererLayer : MonoBehaviour 
{

	TrailRenderer trail;

	void Start()
	{
		trail = GetComponent<TrailRenderer> ();
		trail.sortingOrder = -6;
	}

}
