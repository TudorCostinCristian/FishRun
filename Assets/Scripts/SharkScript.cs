using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkScript : MonoBehaviour
{
    // Start is called before the first frame update
	public GameObject FISH;
	public Transform camera;
	public float speed;
	public float rSpeed;
	private Vector3 targetMove;
	private Player player;
	
    void Start()
    {
		camera = GameObject.Find("Main Camera").transform;
		speed = 4;
		rSpeed = 1;
		targetMove = new Vector3(-100, Random.Range(-1f, 21f), 0);
		player = GameObject.FindObjectOfType<Player>();
		transform.position = new Vector3(-50, 10, 0);
    }

    // Update is called once per frame
    void Update()
    {
		if(player.end == false)
		{
			//Settings updater 
			if((camera.transform.position.x - 30 > transform.position.x || camera.transform.position.x + 160f < transform.position.x) && camera.transform.position.x < 3100f)
			{
				Vector3 auxPosition = new Vector3(camera.transform.position.x + Random.Range(35f, 145f), Random.Range(-1f, 21f), transform.position.z);
				GameObject[] sharks = GameObject.FindGameObjectsWithTag("shark");
				bool flag = false;
				float max_x = auxPosition.x;
				foreach(GameObject shark in sharks)
				{
					if(Vector2.Distance(auxPosition, shark.transform.position) < 10f)
					{
						flag = true;
					}
					if(shark.transform.position.x > max_x) max_x = shark.transform.position.x;
				}
				if(flag == true)
				{
					transform.position = new Vector3(max_x + 20f, auxPosition.y, auxPosition.z);
				}
				else
				{
					transform.position = auxPosition;
				}
				targetMove = new Vector3(camera.transform.position.x - 40f, Random.Range(-1f, 21f), 0);
			}
			
			bool col = FISH.GetComponent<fishScript>().SharkCollision;
			GameObject colObject = FISH.GetComponent<fishScript>().colliderOBJ;
			
			if(Vector2.Distance(transform.position, FISH.transform.position) < 0.3 && col == true && colObject == this.gameObject){
				speed = 30f;
				rSpeed = 5f;
				player.end = true;
				FISH.SetActive(false);
			}
			else if(col == true  && colObject == this.gameObject){
				transform.position = Vector2.MoveTowards(transform.position, FISH.transform.position, 30f * Time.deltaTime);
				Vector2 direction = FISH.transform.position - transform.position;
				float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg + 180f;
				Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
				transform.rotation = Quaternion.Slerp(transform.rotation, rotation, 5f * Time.deltaTime);
			}
			else{
				transform.position = Vector2.MoveTowards(transform.position, targetMove, speed * Time.deltaTime);
				Vector2 direction = targetMove - transform.position;
				float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg + 180f;
				Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
				transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rSpeed * Time.deltaTime);
			}
		}
		else{
			transform.position = Vector2.MoveTowards(transform.position, targetMove, speed * Time.deltaTime);
			Vector2 direction = targetMove - transform.position;
			float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg + 180f;
			Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
			transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rSpeed * Time.deltaTime);
		}
    }
}
