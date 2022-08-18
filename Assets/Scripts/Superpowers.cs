using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Superpowers : MonoBehaviour
{
	public bool BubbleToggle;
	public bool MagnetToggle;
	public bool DoubleScoreToggle;
	public float BubbleTime;
	public float MagnetTime;
	
	public GameObject BubbleSprite;
	private Player player;
	
    void Start()
    {
        BubbleToggle = false;
		MagnetToggle = false;
		DoubleScoreToggle = false;
		BubbleTime = 0f;
		MagnetTime = 0f;
		player = GameObject.FindObjectOfType<Player>();
    }

    void Update()
    {
		if(BubbleToggle == true)
		{
			if(BubbleTime < 0f)
			{
				DeactivateBubble();
				return;
			}
			BubbleTime -= Time.deltaTime;
		}
		
		if(MagnetToggle == true)
		{
			if(MagnetTime < 0f)
			{
				DeactivateMagnet();
				return;
			}
			MagnetTime -= Time.deltaTime;
		}
    }
	
	public void ActivateBubble()
	{
		if(BubbleToggle == true) return;
		if(player.BubbleSP <= 0) return;
		player.BubbleSP--;
		BubbleToggle = true;
		BubbleTime = 10f + (float)player.BubbleSP_Upgrade * 2f;
		BubbleSprite.SetActive(true);
	}
	
	public void DeactivateBubble()
	{
		if(BubbleToggle == false) return;
		BubbleToggle = false;
		BubbleTime = 0f;
		BubbleSprite.SetActive(false);
	}
	
	public void ActivateMagnet()
	{
		if(MagnetToggle == true) return;
		if(player.MagnetSP <= 0) return;
		player.MagnetSP--;
		MagnetToggle = true;
		MagnetTime = 20 + (float)player.MagnetSP_Upgrade * 5f;
	}
	
	public void DeactivateMagnet()
	{
		if(MagnetToggle == false) return;
		MagnetToggle = false;
		MagnetTime = 0f;
	}
	
}
