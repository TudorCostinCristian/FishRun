using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsUpdater : MonoBehaviour
{
	public GameObject[] shark = new GameObject[6];
	public GameObject camera;
	public Player player;
	
	private int[] GD_Score = new int[25];
	private int[] GD_ActiveSharks = new int[25];
	private int[] GD_ActiveRods = new int[25];
	private float[] GD_CameraSpeed = new float[25];
	private float[] GD_SharkSpeed = new float[25];
	
    void Start()
    {
        player = GameObject.FindObjectOfType<Player>();
		GameDifficulty();
    }
	
	void GameDifficulty()
	{
		GD_Score[0] = 15;
		GD_ActiveSharks[0] = 0;
		GD_ActiveRods[0] = 0;
		GD_CameraSpeed[0] = 3f;
		GD_SharkSpeed[0] = 0f;
		
		GD_Score[1] = 30;
		GD_ActiveSharks[1] = 1;
		GD_ActiveRods[1] = 0;
		GD_CameraSpeed[1] = 3.5f;
		GD_SharkSpeed[1] = 3f;
		
		GD_Score[2] = 60;
		GD_ActiveSharks[2] = 1;
		GD_ActiveRods[2] = 0;
		GD_CameraSpeed[2] = 4f;
		GD_SharkSpeed[2] = 3.5f;
		
		GD_Score[3] = 90;
		GD_ActiveSharks[3] = 2;
		GD_ActiveRods[3] = 1;
		GD_CameraSpeed[3] = 4.5f;
		GD_SharkSpeed[3] = 4f;
		
		GD_Score[4] = 120;
		GD_ActiveSharks[4] = 2;
		GD_ActiveRods[4] = 1;
		GD_CameraSpeed[4] = 5f;
		GD_SharkSpeed[4] = 4f;
		
		GD_Score[5] = 150;
		GD_ActiveSharks[5] = 2;
		GD_ActiveRods[5] = 1;
		GD_CameraSpeed[5] = 5.5f;
		GD_SharkSpeed[5] = 4.5f;
		
		GD_Score[6] = 200;
		GD_ActiveSharks[6] = 2;
		GD_ActiveRods[6] = 1;
		GD_CameraSpeed[6] = 6.5f;
		GD_SharkSpeed[6] = 5f;
		
		GD_Score[7] = 250;
		GD_ActiveSharks[7] = 2;
		GD_ActiveRods[7] = 1;
		GD_CameraSpeed[7] = 6.5f;
		GD_SharkSpeed[7] = 5.5f;
		
		GD_Score[8] = 300;
		GD_ActiveSharks[8] = 3;
		GD_ActiveRods[8] = 1;
		GD_CameraSpeed[8] = 7f;
		GD_SharkSpeed[8] = 5.5f;
		
		GD_Score[9] = 350;
		GD_ActiveSharks[9] = 3;
		GD_ActiveRods[9] = 2;
		GD_CameraSpeed[9] = 7.5f;
		GD_SharkSpeed[9] = 5.5f;
		
		GD_Score[10] = 400;
		GD_ActiveSharks[10] = 3;
		GD_ActiveRods[10] = 2;
		GD_CameraSpeed[10] = 7.5f;
		GD_SharkSpeed[10] = 6f;
		
		GD_Score[11] = 450;
		GD_ActiveSharks[11] = 3;
		GD_ActiveRods[11] = 2;
		GD_CameraSpeed[11] = 8f;
		GD_SharkSpeed[11] = 6.5f;
		
		GD_Score[12] = 500;
		GD_ActiveSharks[12] = 4;
		GD_ActiveRods[12] = 2;
		GD_CameraSpeed[12] = 8.5f;
		GD_SharkSpeed[12] = 7f;
		
		GD_Score[13] = 550;
		GD_ActiveSharks[13] = 4;
		GD_ActiveRods[13] = 2;
		GD_CameraSpeed[13] = 9f;
		GD_SharkSpeed[13] = 7.5f;
		
		GD_Score[14] = 650;
		GD_ActiveSharks[14] = 4;
		GD_ActiveRods[14] = 2;
		GD_CameraSpeed[14] = 9.5f;
		GD_SharkSpeed[14] = 8f;
		
		GD_Score[15] = 750;
		GD_ActiveSharks[15] = 5;
		GD_ActiveRods[15] = 2;
		GD_CameraSpeed[15] = 9.5f;
		GD_SharkSpeed[15] = 8.5f;
		
		GD_Score[16] = 850;
		GD_ActiveSharks[16] = 5;
		GD_ActiveRods[16] = 2;
		GD_CameraSpeed[16] = 10f;
		GD_SharkSpeed[16] = 9f;
		
		GD_Score[17] = 1000;
		GD_ActiveSharks[17] = 5;
		GD_ActiveRods[17] = 3;
		GD_CameraSpeed[17] = 10f;
		GD_SharkSpeed[17] = 9f;
		
		GD_Score[18] = 1100;
		GD_ActiveSharks[18] = 5;
		GD_ActiveRods[18] = 3;
		GD_CameraSpeed[18] = 10.5f;
		GD_SharkSpeed[18] = 9.5f;
		
		GD_Score[19] = 1300;
		GD_ActiveSharks[19] = 5;
		GD_ActiveRods[19] = 3;
		GD_CameraSpeed[19] = 10.5f;
		GD_SharkSpeed[19] = 10f;
		
		GD_Score[20] = 1500;
		GD_ActiveSharks[20] = 5;
		GD_ActiveRods[20] = 3;
		GD_CameraSpeed[20] = 11f;
		GD_SharkSpeed[20] = 10.5f;
		
		GD_Score[21] = 1700;
		GD_ActiveSharks[21] = 6;
		GD_ActiveRods[21] = 3;
		GD_CameraSpeed[21] = 11.5f;
		GD_SharkSpeed[21] = 10.5f;
		
		GD_Score[22] = 1700;
		GD_ActiveSharks[22] = 6;
		GD_ActiveRods[22] = 3;
		GD_CameraSpeed[22] = 12f;
		GD_SharkSpeed[22] = 11f;
		
		GD_Score[23] = 2100;
		GD_ActiveSharks[23] = 6;
		GD_ActiveRods[23] = 3;
		GD_CameraSpeed[23] = 13f;
		GD_SharkSpeed[23] = 11.5f;
		
		GD_Score[24] = 2500;
		GD_ActiveSharks[24] = 6;
		GD_ActiveRods[24] = 3;
		GD_CameraSpeed[24] = 14f;
		GD_SharkSpeed[24] = 12f;
		
	}
	
    public void UpdateSettings()
	{
		if(player.LockCameraSpeed == true) return;
		for(int i = 0; i < 25; i++)
		{
			if(player.CurrentScore < GD_Score[i] || i == 24)
			{
				Debug.Log(i.ToString());
				camera.GetComponent<CameraMove>().speed = GD_CameraSpeed[i];
				for(int j = 0; j < GD_ActiveSharks[i]; j++)
				{
					Debug.Log("Activate shark " + j.ToString());
					shark[j].SetActive(true);
					shark[j].GetComponent<SharkScript>().speed = GD_SharkSpeed[i];
				}
				for(int j = GD_ActiveSharks[i]; j < 6; j++)
				{
					shark[j].SetActive(false);
				}
				break;
			}
		}
		/*
		if(player.CurrentScore < 25)
		{
			camera.GetComponent<CameraMove>().speed = 3f;
			for(int i = 0; i < 6; i++)
			{
				shark[i].SetActive(false);
			}
		}
		else if(player.CurrentScore < 100)
		{
			camera.GetComponent<CameraMove>().speed = 3f;
			for(int i = 0; i < 1; i++)
			{
				shark[i].SetActive(true);
				shark[i].GetComponent<SharkScript>().speed = 3f;
			}
			for(int i = 1; i < 6; i++)
			{
				shark[i].SetActive(false);
			}
		}
		else if(player.CurrentScore < 200)
		{
			camera.GetComponent<CameraMove>().speed = 3.5f;
			for(int i = 0; i < 1; i++)
			{
				shark[i].SetActive(true);
				shark[i].GetComponent<SharkScript>().speed = 3f;
			}
			for(int i = 1; i < 6; i++)
			{
				shark[i].SetActive(false);
			}
		}
		*/
	}
}
