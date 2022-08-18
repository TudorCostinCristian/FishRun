using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class fishScript : MonoBehaviour
{
	public float MovementSpeed = 2.5f;
	public GameObject player;
	public PearlCreator pearlCreator;
	public bool SharkCollision;
	public GameObject colliderOBJ;
	public Superpowers SP;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
		SP = GameObject.Find("Canvas").GetComponent<Superpowers>();
		pearlCreator = GameObject.Find("Main Camera").GetComponent<PearlCreator>();
		SharkCollision = false;
    }

    // Update is called once per frame
    void Update()
    {
        var movement = CrossPlatformInputManager.GetAxis("Vertical");
		if(transform.position.y + movement * Time.deltaTime * MovementSpeed < 18.7f && transform.position.y + movement * Time.deltaTime * MovementSpeed > 1.9f){
			transform.position += new Vector3(0, movement, 0) * Time.deltaTime * MovementSpeed;
		}
    }
	
    private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.tag == "pearl")
		{
			Destroy(collision.gameObject);
			pearlCreator.pearlNr = pearlCreator.pearlNr - 1;
			Player p = player.GetComponent<Player>();
			p.Coins = p.Coins + 1;
			p.EarnedCoins = p.EarnedCoins + 1;
		}
		
		if(collision.tag == "shark" && SP.BubbleToggle == false)
		{
			Player p = player.GetComponent<Player>();
			p.GameOver();
			SharkCollision = true;
			colliderOBJ = collision.gameObject;
		}
	}
}
