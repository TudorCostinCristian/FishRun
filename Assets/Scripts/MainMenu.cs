using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class MainMenu : MonoBehaviour
{
	public Text highscoreText;
	public TextMeshProUGUI coinsText;
	public Player player;
	
	public Animator transition;
	
	void Start()
	{
		player = GameObject.FindObjectOfType<Player>();
		highscoreText.text = "HIGHSCORE: " + player.HighScore.ToString("0");
		coinsText.text = player.Coins.ToString() + " <sprite=0>";
	}
	
    public void PlayGame()
	{
		StartCoroutine(PlayGameCoroutine());
	}
	
	
	/*IEnumerator PlayGameAsync()
	{
		transition.SetTrigger("Start");
		yield return new WaitForSeconds(1f);
		AsyncOperation operation = SceneManager.LoadSceneAsync("Scene2");
		while(!operation.isDone)
		{
			Debug.Log(operation.progress);
			yield return null;
		}
	}*/
	
	IEnumerator PlayGameCoroutine()
	{
		transition.SetTrigger("Start");
		
		yield return new WaitForSeconds(1f);
		
		SceneManager.LoadScene("Scene2");
	}
	
	public void SelectFish()
	{
		StartCoroutine(SelectFishCoroutine());
	}
	
	IEnumerator SelectFishCoroutine()
	{
		transition.SetTrigger("Start");
		
		yield return new WaitForSeconds(1f);
		
		SceneManager.LoadScene("Scene_SelectFish");
	}
}
