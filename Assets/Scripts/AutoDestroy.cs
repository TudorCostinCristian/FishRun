using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AutoDestroy : MonoBehaviour
{
    public Transform camera;
	public PearlCreator pearlCreator;
	public GameObject FISH;
	public Superpowers SP;
	
    void Start()
    {
        camera = GameObject.Find("Main Camera").transform;
		pearlCreator = GameObject.Find("Main Camera").GetComponent<PearlCreator>();
		FISH = GameObject.Find("Fish");
		SP = GameObject.Find("Canvas").GetComponent<Superpowers>();
    }

    void Update()
    {
        if(camera.position.x - 75 > transform.position.x || camera.position.x + 75 < transform.position.x)
		{
			Destroy(gameObject);
			pearlCreator.pearlNr = pearlCreator.pearlNr - 1;
		}
		
		if(SP.MagnetToggle == true) // magnet superpower
		{
			transform.position = Vector2.MoveTowards(transform.position, FISH.transform.position, 30f * Time.deltaTime);
		}
    }
}
