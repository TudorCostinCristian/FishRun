using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSkin : MonoBehaviour
{
	public GameObject bottomFin;
	public GameObject Eye;
	public GameObject EyeColor;
	public GameObject sideFin;
	public GameObject Lip;
	public GameObject Tail;
	public GameObject UpFin;
	public GameObject bottomFinBig;
	public GameObject Bubble;
	public int FishNr;
	
    // Start is called before the first frame update
    void Start()
    {
		
		GameObject player = GameObject.Find("Player");
		FishNr = player.GetComponent<Player>().SelectedFish;
		
		Debug.Log(FishNr.ToString());
		
		SpriteRenderer spriteRenderer;
		Sprite newSprite;
		
		
		string SpriteName;
		
		SpriteName = "Fish" + FishNr.ToString() + "body";
        spriteRenderer = GetComponent<SpriteRenderer>();
		newSprite = Resources.Load<Sprite>(SpriteName);
		spriteRenderer.sprite = newSprite;
		
		SpriteName = "Fish" + FishNr.ToString() + "SmallBottomFin";
		spriteRenderer = bottomFin.GetComponent<SpriteRenderer>();
		newSprite = Resources.Load<Sprite>(SpriteName);
		spriteRenderer.sprite = newSprite;
		
		SpriteName = "Fish" + FishNr.ToString() + "eye";
		spriteRenderer = Eye.GetComponent<SpriteRenderer>();
		newSprite = Resources.Load<Sprite>(SpriteName);
		spriteRenderer.sprite = newSprite;
		
		SpriteName = "Fish" + FishNr.ToString() + "eyecolor";
		spriteRenderer = EyeColor.GetComponent<SpriteRenderer>();
		newSprite = Resources.Load<Sprite>(SpriteName);
		spriteRenderer.sprite = newSprite;
		
		SpriteName = "Fish" + FishNr.ToString() + "SideFin";
		spriteRenderer = sideFin.GetComponent<SpriteRenderer>();
		newSprite = Resources.Load<Sprite>(SpriteName);
		spriteRenderer.sprite = newSprite;
		
		SpriteName = "Fish" + FishNr.ToString() + "LipClose";
		spriteRenderer = Lip.GetComponent<SpriteRenderer>();
		newSprite = Resources.Load<Sprite>(SpriteName);
		spriteRenderer.sprite = newSprite;
		
		SpriteName = "Fish" + FishNr.ToString() + "Tail";
		spriteRenderer = Tail.GetComponent<SpriteRenderer>();
		newSprite = Resources.Load<Sprite>(SpriteName);
		spriteRenderer.sprite = newSprite;
		
		SpriteName = "Fish" + FishNr.ToString() + "UpFin";
		spriteRenderer = UpFin.GetComponent<SpriteRenderer>();
		newSprite = Resources.Load<Sprite>(SpriteName);
		spriteRenderer.sprite = newSprite;
		
		SpriteName = "Fish" + FishNr.ToString() + "BottomFin";
		spriteRenderer = bottomFinBig.GetComponent<SpriteRenderer>();
		newSprite = Resources.Load<Sprite>(SpriteName);
		spriteRenderer.sprite = newSprite;
		
		switch(FishNr){
			case 1:
				bottomFin.transform.localPosition = new Vector3(0.97f, -1.71f, 0f);
				Eye.transform.localPosition = new Vector3(2.29f, -0.47f, 0f);
				EyeColor.transform.localPosition = new Vector3(0.118f, 0.108f, 0f);
				sideFin.transform.localPosition = new Vector3(1.52f, -0.63f, 0f);
				Lip.transform.localPosition = new Vector3(2.89f, -0.6f, 0f);
				Tail.transform.localPosition = new Vector3(-2.67f, -0.41f, 0f);
				UpFin.transform.localPosition = new Vector3(-0.92f, 1.12f, 0f);
				bottomFinBig.transform.localPosition = new Vector3(-1.47f, -1.38f, 0f);
				Bubble.transform.localPosition = new Vector3(-0.43f, -0.29f, -29.98f);
				Bubble.transform.localScale = new Vector3(4.31f, 4.31f, 4.31f);
				break;
			case 2:
				bottomFin.transform.localPosition = new Vector3(1.4f, -1.32f, 0f);
				Eye.transform.localPosition = new Vector3(1.41f, 0.34f, 0f);
				EyeColor.transform.localPosition = new Vector3(0.11f, 0.108f, 0f);
				sideFin.transform.localPosition = new Vector3(0.86f, -0.49f, 0f);
				Lip.transform.localPosition = new Vector3(3.108f, -0.311f, 0f);
				Tail.transform.localPosition = new Vector3(-2.96f, -0.26f, 0f);
				UpFin.transform.localPosition = new Vector3(-1.19f, 1.38f, 0f);
				bottomFinBig.transform.localPosition = new Vector3(-1.29f, -1.34f, 0f);
				Bubble.transform.localPosition = new Vector3(-1.9f, -0.04f, -29.98f);
				Bubble.transform.localScale = new Vector3(5.09f, 5.09f, 5.09f);
				break;
			case 3:
				bottomFin.transform.localPosition = new Vector3(1.22f, -1.54f, 0f);
				Eye.transform.localPosition = new Vector3(2.14f, -0.43f, 0f);
				EyeColor.transform.localPosition = new Vector3(0.11f, 0.108f, 0f);
				sideFin.transform.localPosition = new Vector3(1.54f, -0.82f, 0f);
				Lip.transform.localPosition = new Vector3(3.11f, -0.53f, 0f);
				Tail.transform.localPosition = new Vector3(-2.79f, -0.36f, 0f);
				UpFin.transform.localPosition = new Vector3(-1.75f, 0.89f, 0f);
				bottomFinBig.transform.localPosition = new Vector3(-1.41f, -1.08f, 0f);
				Bubble.transform.localPosition = new Vector3(-0.97f, -0.04f, -29.98f);
				Bubble.transform.localScale = new Vector3(4.31f, 4.31f, 4.31f);
				break;
			case 4:
				bottomFin.transform.localPosition = new Vector3(1.56f, -1.66f, 0f);
				Eye.transform.localPosition = new Vector3(2.22f, -0.19f, 0f);
				EyeColor.transform.localPosition = new Vector3(0.11f, 0.108f, 0f);
				sideFin.transform.localPosition = new Vector3(1.58f, -0.88f, 0f);
				Lip.transform.localPosition = new Vector3(3.07f, -0.53f, 0f);
				Tail.transform.localPosition = new Vector3(-2.73f, -0.36f, 0f);
				UpFin.transform.localPosition = new Vector3(-0.88f, 1.35f, 0f);
				bottomFinBig.transform.localPosition = new Vector3(-1.34f, -1.39f, 0f);
				Bubble.transform.localPosition = new Vector3(-0.97f, -0.04f, -29.98f);
				Bubble.transform.localScale = new Vector3(4.31f, 4.31f, 4.31f);
				break;
			case 5:
				bottomFin.transform.localPosition = new Vector3(1.42f, -1.43f, 0f);
				Eye.transform.localPosition = new Vector3(2.19f, -0.37f, 0f);
				EyeColor.transform.localPosition = new Vector3(0.11f, 0.108f, 0f);
				sideFin.transform.localPosition = new Vector3(1.31f, -0.7f, 0f);
				Lip.transform.localPosition = new Vector3(3.17f, -0.48f, 0f);
				Tail.transform.localPosition = new Vector3(-2.73f, -0.36f, 0f);
				UpFin.transform.localPosition = new Vector3(-0.93f, 1.12f, 0f);
				bottomFinBig.transform.localPosition = new Vector3(-1.52f, -1.15f, 0f);
				Bubble.transform.localPosition = new Vector3(-0.97f, -0.04f, -29.98f);
				Bubble.transform.localScale = new Vector3(4.31f, 4.31f, 4.31f);
				break;
			case 6:
				bottomFin.transform.localPosition = new Vector3(1.57f, -1.42f, 0f);
				Eye.transform.localPosition = new Vector3(2.15f, 0.34f, 0f);
				EyeColor.transform.localPosition = new Vector3(0.11f, 0.108f, 0f);
				sideFin.transform.localPosition = new Vector3(1.6f, -0.42f, 0f);
				Lip.transform.localPosition = new Vector3(3.2f, -0.14f, 0f);
				Tail.transform.localPosition = new Vector3(-3.042f, -0.083f, 0f);
				UpFin.transform.localPosition = new Vector3(-0.93f, 1.12f, 0f);
				bottomFinBig.transform.localPosition = new Vector3(-1.27f, -1.17f, 0f);
				Bubble.transform.localPosition = new Vector3(-0.97f, -0.04f, -29.98f);
				Bubble.transform.localScale = new Vector3(4.31f, 4.31f, 4.31f);
				break;
			case 7:
				bottomFin.transform.localPosition = new Vector3(0.38f, -1.36f, 0f);
				Eye.transform.localPosition = new Vector3(1.78f, 0.31f, 0f);
				EyeColor.transform.localPosition = new Vector3(0.11f, 0.108f, 0f);
				sideFin.transform.localPosition = new Vector3(0.42f, -0.14f, 0f);
				Lip.transform.localPosition = new Vector3(2.88f, -0.115f, 0f);
				Tail.transform.localPosition = new Vector3(-2.59f, -0.01f, 0f);
				UpFin.transform.localPosition = new Vector3(-0.83f, 1.06f, 0f);
				bottomFinBig.transform.localPosition = new Vector3(-1.48f, -0.97f, 0f);
				Bubble.transform.localPosition = new Vector3(-0.97f, -0.04f, -29.98f);
				Bubble.transform.localScale = new Vector3(4.31f, 4.31f, 4.31f);
				break;
			case 8:
				bottomFin.transform.localPosition = new Vector3(0.38f, -1.36f, 0f);
				Eye.transform.localPosition = new Vector3(1.79f, 0.6f, 0f);
				EyeColor.transform.localPosition = new Vector3(0.11f, 0.108f, 0f);
				sideFin.transform.localPosition = new Vector3(1.04f, -0.51f, 0f);
				Lip.transform.localPosition = new Vector3(3.39f, 0.03f, 0f);
				Tail.transform.localPosition = new Vector3(-3.092f, 0.09f, 0f);
				UpFin.transform.localPosition = new Vector3(-1.958f, 1.06f, 0f);
				bottomFinBig.transform.localPosition = new Vector3(-2.23f, -0.83f, 0f);
				Bubble.transform.localPosition = new Vector3(-0.74f, 0.15f, -29.98f);
				Bubble.transform.localScale = new Vector3(4.61f, 4.61f, 4.61f);
				break;
			case 9:
				bottomFin.transform.localPosition = new Vector3(0.95f, -1f, 0f);
				Eye.transform.localPosition = new Vector3(2.57f, -0.02f, 0f);
				EyeColor.transform.localPosition = new Vector3(0.11f, 0.108f, 0f);
				sideFin.transform.localPosition = new Vector3(1.25f, -0.42f, 0f);
				Lip.transform.localPosition = new Vector3(3.39f, -0.12f, 0f);
				Tail.transform.localPosition = new Vector3(-3.25f, 0.01f, 0f);
				UpFin.transform.localPosition = new Vector3(-0.92f, 1f, 0f);
				bottomFinBig.transform.localPosition = new Vector3(-2.18f, -0.76f, 0f);
				Bubble.transform.localPosition = new Vector3(-0.74f, 0.15f, -29.98f);
				Bubble.transform.localScale = new Vector3(4.61f, 4.61f, 4.61f);
				break;
			case 10:
				bottomFin.transform.localPosition = new Vector3(1.06f, -1.24f, 0f);
				Eye.transform.localPosition = new Vector3(2.15f, -0.13f, 0f);
				EyeColor.transform.localPosition = new Vector3(0.11f, 0.108f, 0f);
				sideFin.transform.localPosition = new Vector3(1.39f, -0.49f, 0f);
				Lip.transform.localPosition = new Vector3(2.935f, -0.21f, 0f);
				Tail.transform.localPosition = new Vector3(-2.95f, -0.22f, 0f);
				UpFin.transform.localPosition = new Vector3(-0.37f, 1.08f, 0f);
				bottomFinBig.transform.localPosition = new Vector3(-1.53f, -1.06f, 0f);
				Bubble.transform.localPosition = new Vector3(-0.97f, -0.04f, -29.98f);
				Bubble.transform.localScale = new Vector3(4.31f, 4.31f, 4.31f);
				break;
			case 11:
				bottomFin.transform.localPosition = new Vector3(1.29f, -2.12f, 0f);
				Eye.transform.localPosition = new Vector3(2.47f, 0.11f, 0f);
				EyeColor.transform.localPosition = new Vector3(0.11f, 0.108f, 0f);
				sideFin.transform.localPosition = new Vector3(1.92f, -0.64f, 0f);
				Lip.transform.localPosition = new Vector3(3.23f, -0.09f, 0f);
				Tail.transform.localPosition = new Vector3(-3.04f, -0.11f, 0f);
				UpFin.transform.localPosition = new Vector3(-0.46f, 2.09f, 0f);
				bottomFinBig.transform.localPosition = new Vector3(-1.28f, -1.85f, 0f);
				Bubble.transform.localPosition = new Vector3(-0.74f, 0.15f, -29.98f);
				Bubble.transform.localScale = new Vector3(4.61f, 4.61f, 4.61f);
				break;
			case 12:
				bottomFin.transform.localPosition = new Vector3(0.96f, -1.71f, 0f);
				Eye.transform.localPosition = new Vector3(2.33f, 0.07f, 0f);
				EyeColor.transform.localPosition = new Vector3(0.11f, 0.108f, 0f);
				sideFin.transform.localPosition = new Vector3(1.18f, -0.48f, 0f);
				Lip.transform.localPosition = new Vector3(3.263f, -0.174f, 0f);
				Tail.transform.localPosition = new Vector3(-2.97f, -0.04f, 0f);
				UpFin.transform.localPosition = new Vector3(-0.72f, 1.81f, 0f);
				bottomFinBig.transform.localPosition = new Vector3(-1.557f, -1.333f, 0f);
				Bubble.transform.localPosition = new Vector3(-0.97f, -0.04f, -29.98f);
				Bubble.transform.localScale = new Vector3(4.31f, 4.31f, 4.31f);
				break;
			case 13:
				bottomFin.transform.localPosition = new Vector3(-0.51f, -1.56f, 0f);
				Eye.transform.localPosition = new Vector3(2.208f, -0.235f, 0f);
				EyeColor.transform.localPosition = new Vector3(0.118f, 0.108f, 0f);
				sideFin.transform.localPosition = new Vector3(1.21f, -0.17f, 0f);
				Lip.transform.localPosition = new Vector3(3.064f, -0.35f, 0f);
				Tail.transform.localPosition = new Vector3(-2.59f, -0.04f, 0f);
				UpFin.transform.localPosition = new Vector3(-0.81f, 1.56f, 0f);
				bottomFinBig.transform.localPosition = new Vector3(-0.49f, -0.98f, 0f);
				Bubble.transform.localPosition = new Vector3(-1.21f, -0.05f, -29.98f);
				Bubble.transform.localScale = new Vector3(4.75f, 4.75f, 4.75f);
				break;
			case 14:
				bottomFin.transform.localPosition = new Vector3(0.72f, -1.99f, 0f);
				Eye.transform.localPosition = new Vector3(2.53f, 0.36f, 0f);
				EyeColor.transform.localPosition = new Vector3(0.118f, 0.108f, 0f);
				sideFin.transform.localPosition = new Vector3(1.84f, -0.33f, 0f);
				Lip.transform.localPosition = new Vector3(3.1f, -0.04f, 0f);
				Tail.transform.localPosition = new Vector3(-2.66f, 0f, 0f);
				UpFin.transform.localPosition = new Vector3(-1.21f, 1.52f, 0f);
				bottomFinBig.transform.localPosition = new Vector3(-1.872f, -2.09f, 0f);
				Bubble.transform.localPosition = new Vector3(-0.97f, -0.04f, -29.98f);
				Bubble.transform.localScale = new Vector3(4.31f, 4.31f, 4.31f);
				break;
			case 15:
				bottomFin.transform.localPosition = new Vector3(-0.72f, -1.99f, 0f);
				Eye.transform.localPosition = new Vector3(2.07f, 0.62f, 0f);
				EyeColor.transform.localPosition = new Vector3(0.118f, 0.108f, 0f);
				sideFin.transform.localPosition = new Vector3(1.27f, -0.01f, 0f);
				Lip.transform.localPosition = new Vector3(3.1f, -0.29f, 0f);
				Tail.transform.localPosition = new Vector3(-2.82f, -0.05f, 0f);
				UpFin.transform.localPosition = new Vector3(-0.5f, 0.91f, 0f);
				bottomFinBig.transform.localPosition = new Vector3(-0.81f, -1.59f, 0f);
				Bubble.transform.localPosition = new Vector3(-0.97f, -0.04f, -29.98f);
				Bubble.transform.localScale = new Vector3(4.31f, 4.31f, 4.31f);
				break;
			default:
				bottomFin.transform.localPosition = new Vector3(0.97f, -1.71f, 0f);
				Eye.transform.localPosition = new Vector3(2.29f, -0.47f, 0f);
				EyeColor.transform.localPosition = new Vector3(0.118f, 0.108f, 0f);
				sideFin.transform.localPosition = new Vector3(1.52f, -0.63f, 0f);
				Lip.transform.localPosition = new Vector3(2.89f, -0.6f, 0f);
				Tail.transform.localPosition = new Vector3(-2.67f, -0.41f, 0f);
				UpFin.transform.localPosition = new Vector3(-0.92f, 1.12f, 0f);
				bottomFinBig.transform.localPosition = new Vector3(-1.47f, -1.38f, 0f);
				Bubble.transform.localPosition = new Vector3(-0.97f, -0.04f, -29.98f);
				Bubble.transform.localScale = new Vector3(4.31f, 4.31f, 4.31f);
				break;
		}
		Animator animator = GetComponent<Animator>();
		SpriteName = "Animations/Fish" + FishNr.ToString();
		animator.runtimeAnimatorController = Resources.Load(SpriteName) as RuntimeAnimatorController;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
