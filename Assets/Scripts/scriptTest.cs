using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptTest : MonoBehaviour
{
	private SpriteRenderer rend;
	private Sprite sharkSprite;
	public float SharkSpeed = 10f;
	public Transform camera;
	GameObject objToSpawn;
	private SpriteRenderer sprite;
	
	
    void Start()
    {
         //spawn object
		 camera = GameObject.Find("Main Camera").transform;
         objToSpawn = new GameObject("Shark");
		 objToSpawn.transform.SetParent(camera);
		 objToSpawn.AddComponent<SpriteRenderer>();
		 rend = objToSpawn.GetComponent<SpriteRenderer>();
		 sharkSprite = Resources.Load<Sprite>("shark");
         rend.sprite = sharkSprite;
		 objToSpawn.transform.position = new Vector3(17.52f, Random.Range(0f, 20f), 0);
		 sprite = objToSpawn.GetComponent<SpriteRenderer>();
		 sprite.sortingLayerName = "Fish";
    }

    // Update is called once per frame
    void Update()
    {
		if (objToSpawn)
		{
			var movementX = -1;
			var movementY = 0;
			SharkSpeed = 10f;
			objToSpawn.transform.position += new Vector3(movementX, movementY, 0) * Time.deltaTime * SharkSpeed;
			Debug.Log(objToSpawn.transform.position.x.ToString());
			if(objToSpawn.transform.position.x < -20f)
			{
				Destroy(objToSpawn);
				camera = GameObject.Find("Main Camera").transform;
				objToSpawn = new GameObject("Shark");
				objToSpawn.transform.SetParent(camera);
				objToSpawn.AddComponent<SpriteRenderer>();
				rend = objToSpawn.GetComponent<SpriteRenderer>();
				sharkSprite = Resources.Load<Sprite>("shark");
				rend.sprite = sharkSprite;
				objToSpawn.transform.position = new Vector3(17.52f, Random.Range(0f, 20f), 0);
				sprite = objToSpawn.GetComponent<SpriteRenderer>();
				sprite.sortingLayerName = "Fish";
			}
		}
    }
}
