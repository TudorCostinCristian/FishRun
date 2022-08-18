using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class PlayerData
{
	public float HighScore;
	public int SelectedFish;
	public int Coins;
	public bool[] FishStatus = new bool[15];
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
	
	public PlayerData()
	{
		CurrentScore = 0;
		EarnedCoins = 0;
		revived = false;
		continueAvailable = true;
		HighScore = 0;
		SelectedFish = 1;
		Coins = 0;
		FishStatus[0] = true;
		for(int i = 1; i < 15; i++) FishStatus[i] = false;
		BubbleSP = 0;
		MagnetSP = 0;
		DoubleScoreSP = 0;
		BubbleSP_Upgrade = 0;
		MagnetSP_Upgrade = 0;
		DoubleScoreSP_Upgrade = 0;
	}
	
	public PlayerData(Player player)
	{
		CurrentScore = player.CurrentScore;
		EarnedCoins = player.EarnedCoins;
		revived = player.revived;
		continueAvailable = player.continueAvailable;
		HighScore = player.HighScore;
		SelectedFish = player.SelectedFish;
		Coins = player.Coins;
		for(int i = 0; i < 15; i++) FishStatus[i] = player.FishStatus[i];
		BubbleSP = player.BubbleSP;
		MagnetSP = player.MagnetSP;
		DoubleScoreSP = player.DoubleScoreSP;
		BubbleSP_Upgrade = player.BubbleSP_Upgrade;
		MagnetSP_Upgrade = player.MagnetSP_Upgrade;
		DoubleScoreSP_Upgrade = player.DoubleScoreSP_Upgrade;
	}
}
