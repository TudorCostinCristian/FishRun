using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreUpdater : MonoBehaviour
{
	public Text scoreText;
	public Text highscoreText;
	public TextMeshProUGUI coinsText;
	
	private Player player;
	
	void Awake(){
		player = GameObject.FindObjectOfType<Player>();
	}
	
    // Update is called once per frame
    void Update()
    {
		scoreText.text = "SCORE: " + player.CurrentScore.ToString("0");
		highscoreText.text = "HIGHSCORE: " + player.HighScore.ToString("0");
		coinsText.text = player.Coins.ToString() + " <sprite=0>";
		
    }
}
