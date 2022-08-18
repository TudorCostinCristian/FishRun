using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuFish : MonoBehaviour
{
    // Start is called before the first frame update
	public float MenuFishSpeed = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if(transform.position != null){
			transform.position += new Vector3(1, 0, 0) * Time.deltaTime * MenuFishSpeed;
			if(transform.position.x > 25f) transform.position += new Vector3(-50, 0, 0);
		}
    }
}
