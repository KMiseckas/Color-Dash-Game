using UnityEngine;
using System.Collections;

public class ChangeButtonSprite : MonoBehaviour 
{
	[Header("Button Sprites")]
	public GameObject col_1;
	public GameObject col_2;
	public GameObject col_3;

	[Header("Default/New Sprites")]
	public Sprite defaultSprite;
	public Sprite newSprite;

	SpriteRenderer colSprite_1;
	SpriteRenderer colSprite_2;
	SpriteRenderer colSprite_3;

	void Start()
	{
		colSprite_1 = col_1.GetComponent<SpriteRenderer> ();
		colSprite_2 = col_2.GetComponent<SpriteRenderer> ();
		colSprite_3 = col_3.GetComponent<SpriteRenderer> ();
	}

	public void SetSprite(int spriteColBtn)
	{
		//Change to new sprite, and reset others to default
		switch(spriteColBtn)
		{
		case 1:
			colSprite_1.sprite = newSprite;
			colSprite_2.sprite = defaultSprite;
			colSprite_3.sprite = defaultSprite;
			break;
		case 2:
			colSprite_2.sprite = newSprite;
			colSprite_1.sprite = defaultSprite;
			colSprite_3.sprite = defaultSprite;
			break;
		case 3:
			colSprite_3.sprite = newSprite as Sprite;
			colSprite_1.sprite = defaultSprite;
			colSprite_2.sprite = defaultSprite;
			break;
		}
	}
}
