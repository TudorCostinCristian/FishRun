using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class Player : MonoBehaviour
{
	public Transform camera;
	public float HighScore;
	public int SelectedFish;
	public int Coins;
	public bool[] FishStatus = new bool[15];
	public bool end;
	public bool LockCameraSpeed;
	public int BubbleSP;
	public int MagnetSP;
	public int DoubleScoreSP;
	public int BubbleSP_Upgrade;
	public int MagnetSP_Upgrade;
	public int DoubleScoreSP_Upgrade;
	
	//CURRENT GAME VARIABLES
	public float CurrentScore;
	public int EarnedCoins;
	public bool revived;
	public bool continueAvailable;
	//----------------------
	
	private static GameObject instance;
	
	public EndMenu endMenu;
	
	private int Loaded = 0;
	private float LastCamera = 0f;
	private float aux;
	public float LastTime = -100f;
	
	void Start()
	{
		if (instance == null)
			instance = gameObject;
		else
			Destroy(gameObject);
		LoadPlayer();
		Loaded = 1;
		end = false;
		LockCameraSpeed = false;
		//camera = GameObject.Find("Main Camera").transform;
	}
	
	void Update()
	{
		Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == "Scene2") 
        {
			camera = GameObject.Find("Main Camera").transform; // de modificat sa nu se mai schimbe la fiecare update
			endMenu = GameObject.Find("Canvas").GetComponent<EndMenu>();
        }
		else
		{
			camera = null;
		}
		
		
		if(Loaded == 1 && camera != null)
		{
			aux = (camera.position.x - LastCamera) * 0.55f;
			if(aux > 0) CurrentScore += aux;
			if(CurrentScore > HighScore)
			{
				HighScore = CurrentScore;
			}
			LastCamera = camera.position.x;
			if(LastTime + 1.2 < Time.time && end == false)
			{
				GameObject.Find("Settings").GetComponent<SettingsUpdater>().UpdateSettings();
				LastTime = Time.time;
			}
		}
	}
	
	
	public void GameOver()
	{
		Debug.Log("GAME OVER");
		continueAvailable = false;
		GameObject.Find("Main Camera").GetComponent<CameraMove>().speed = 0;
		LockCameraSpeed = true;
		if(revived == true)
		{
			endMenu.GameOver();
		}
		else{
			revived = true;
			endMenu.Revive();
		}
	}
	
	public void SavePlayer()
	{
		SaveSystem.SavePlayer(this);
	}
	
	public void LoadPlayer()
	{
		PlayerData data = SaveSystem.LoadPlayer();
		HighScore = data.HighScore;
		SelectedFish = data.SelectedFish;
		Coins = data.Coins;
		if(SelectedFish < 1 || SelectedFish > 15) SelectedFish = 1;
		for(int i = 1; i < 15; i++) FishStatus[i] = data.FishStatus[i];
		FishStatus[0] = true;
		continueAvailable = data.continueAvailable;
		if(continueAvailable == false)
		{
			revived = false;
			EarnedCoins = 0;
			CurrentScore = 0f;
			continueAvailable = true;
		}
		else
		{
			CurrentScore = data.CurrentScore;
			revived = data.revived;
			EarnedCoins = data.EarnedCoins;
		}
		BubbleSP = data.BubbleSP;
		MagnetSP = data.MagnetSP;
		DoubleScoreSP = data.DoubleScoreSP;
		
		BubbleSP_Upgrade = data.BubbleSP_Upgrade;
		MagnetSP_Upgrade = data.MagnetSP_Upgrade;
		DoubleScoreSP_Upgrade = data.DoubleScoreSP_Upgrade;
		
	}
	
    void OnApplicationQuit()
    {
        Debug.Log("Application ending after " + Time.time + " seconds");
		// salvare date
		SavePlayer();
    }
	
}
