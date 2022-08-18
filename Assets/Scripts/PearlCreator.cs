using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PearlCreator : MonoBehaviour
{
    // Start is called before the first frame update
	public int pearlNr;
	public float LastTime;
	public CameraMove cameraMove;
	
    void Start()
    {
        pearlNr = 0;
		LastTime = 0f;
		cameraMove = GameObject.Find("Main Camera").GetComponent<CameraMove>();
    }

    // Update is called once per frame
    void Update()
    {
		if(pearlNr < 25 && transform.position.x < 3180f && LastTime + 10f/cameraMove.speed < Time.time)
		{
			GameObject pearl;
			SpriteRenderer rend;
			Sprite pearlSprite;
			Animator anim;
			CircleCollider2D collider;
		
			pearl = new GameObject("Pearl");
			pearl.tag = "pearl";
		
			pearl.AddComponent<SpriteRenderer>();
			rend = pearl.GetComponent<SpriteRenderer>();
			pearlSprite = Resources.Load<Sprite>("pearl");
			rend.sprite = pearlSprite;
			rend.sortingLayerName = "Fish";
		
			pearl.transform.position = new Vector3(transform.position.x + 40f, Random.Range(2f, 19f), 0);
			pearl.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
		
			pearl.AddComponent<Animator>();
			anim = pearl.GetComponent<Animator>();
			anim.runtimeAnimatorController = Resources.Load("Animations/ShellAnim") as RuntimeAnimatorController;
		
			pearl.AddComponent<AutoDestroy>();
		
			pearl.AddComponent<CircleCollider2D>();
			collider = pearl.GetComponent<CircleCollider2D>();
			collider.isTrigger = true;
			collider.offset = new Vector2(-0.15f, 0.56f);
			collider.radius = 2f;
			pearlNr = pearlNr + 1;
			LastTime = Time.time;
		}
    }
}
