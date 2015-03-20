using UnityEngine;
using System.Collections;

public class ColorChange : MonoBehaviour 
{

	[Header("Colors")]
	public Color col_1;
	public Color col_2;
	public Color col_3;
	public Color col_4;

	private string currentColor = "default";
	private bool colorChangeEnabled = true;

	SpriteRenderer thisSprite;

	public string CurrentColor 
	{
		get 
		{
			return currentColor;
		}
		set 
		{
			currentColor = value;
		}
	}

	public bool setColorChange
	{
		get 
		{
			return colorChangeEnabled;
		}
		set 
		{
			colorChangeEnabled = value;
		}
	}

	void Start()
	{
		thisSprite = GetComponent<SpriteRenderer>();
	}

	void Update()
	{

		//CODE FOR TESTING ON PC -------------------------
		if(Input.GetKeyDown(KeyCode.Q))
		{
			SetColor(1);
		}

		if(Input.GetKeyDown(KeyCode.W))
		{
			SetColor(2);
		}

		if(Input.GetKeyDown(KeyCode.E))
		{
			SetColor(3);
		}
		//----------------------------------------------------
	}
	
	public void SetColor(int num)
	{
		//Change color of sprite
		if(colorChangeEnabled)
		{
			switch(num)
			{
			case 1:
				thisSprite.color = col_1;
				currentColor = "Col_1";
				break;
			case 2:
				thisSprite.color = col_2;
				currentColor = "Col_2";
				break;
			case 3:
				thisSprite.color = col_3;
				currentColor = "Col_3";
				break;
			case 4:
				thisSprite.color = col_4;
				currentColor = "Col_4";
				break;
			}
		}
	}


}
