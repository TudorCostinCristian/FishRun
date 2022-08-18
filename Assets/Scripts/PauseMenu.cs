using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
	
	public static bool GamePaused = false;
	public GameObject pauseMenu;
	public Animator transition;

    void Update()
    {
        
    }
	
	public void Pause()
	{
		pauseMenu.SetActive(true);
		Time.timeScale = 0f;
		GamePaused = true;
	}
	
	public void Resume()
	{
		pauseMenu.SetActive(false);
		Time.timeScale = 1f;
		GamePaused = false;
	}
	
	public void BackToMainMenu()
	{
		//update Player
		GamePaused = false;
		Time.timeScale = 1f;
		StartCoroutine(BackToMainMenuCoroutine());
	}
	
	IEnumerator BackToMainMenuCoroutine()
	{
		transition.SetTrigger("Start");
		
		yield return new WaitForSeconds(1f);
		
		SceneManager.LoadScene("MainMenu");
	}
	
}
