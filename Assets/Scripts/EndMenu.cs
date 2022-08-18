using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EndMenu : MonoBehaviour
{
	public GameObject endMenu;
	public GameObject reviveMenu;
	public Text reviveText;
	public GameObject FISH;
	public Player player;
	public TextMeshProUGUI coinsText;
	public TextMeshProUGUI scoreText;
	
	private float reviveTimer;
	private bool reviveStarted;
	
	void Start()
	{
		reviveStarted = false;
		player = GameObject.FindObjectOfType<Player>();
	}
	
	void Update()
	{
		if(reviveStarted == true)
		{
			reviveTimer -= Time.deltaTime;
			if(reviveTimer < 0.55f)
			{
				reviveStarted = false;
				reviveMenu.SetActive(false);
				GameOver();
			}
			else
			{
				reviveText.text = reviveTimer.ToString("0");
			}
		}
	}
	
	public void GameOver()
	{
		coinsText.text = "COLLECTED: " + player.EarnedCoins.ToString() + " <sprite=0>";
		if(player.CurrentScore < player.HighScore) scoreText.text = "SCORE: " + player.CurrentScore.ToString("0");
		else scoreText.text = "SCORE: " + player.CurrentScore.ToString("0") + " (NEW HIGHSCORE)";
		endMenu.SetActive(true);
		
	}
	
	public void Revive()
	{
		reviveMenu.SetActive(true);
		reviveTimer = 5.45f;
		reviveStarted = true;
	}
	
	public void ReviveClicked()
	{
		reviveStarted = false;
		reviveMenu.SetActive(false);
		FISH.SetActive(true);
		FISH.GetComponent<fishScript>().SharkCollision = false;
		FISH.GetComponent<fishScript>().colliderOBJ = null;
		player.end = false;
		player.LockCameraSpeed = false;
		player.continueAvailable = true;
	}
	
	
}
