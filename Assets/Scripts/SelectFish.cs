using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class SelectFish : MonoBehaviour
{
	public Text statusText;
	public TextMeshProUGUI coinsText;
	public TextMeshProUGUI selectedText;
	public Button buyButton;
	public Button selectButton;
	public Player player;
	public int FishNr;
	public int[] FishPrice = new int[15];
	
	public Animator transition;
	
    void Start()
    {
		player = GameObject.Find("Player").GetComponent<Player>();
		//player.SelectedFish = 14;
		FishPrice[0] = 0;
		FishPrice[1] = 500;
		FishPrice[2] = 1000;
		FishPrice[3] = 2100;
		FishPrice[4] = 3300;
		FishPrice[5] = 3800;
		FishPrice[6] = 12000;
		FishPrice[7] = 4800;
		FishPrice[8] = 15000;
		FishPrice[9] = 20000;
		FishPrice[10] = 7800;
		FishPrice[11] = 10000;
		FishPrice[12] = 9200;
		FishPrice[13] = 6700;
		FishPrice[14] = 5500;
        FishNr = 1;
		ShowFishNr(FishNr);
    }
	
	
    void Update()
    {
        coinsText.text = player.Coins.ToString() + " <sprite=0>";
    }
	
	public void NextFish()
	{
		if(FishNr == 15) return;
		FishNr = FishNr + 1;
		ShowFishNr(FishNr);
	}
	
	public void PrevFish()
	{
		if(FishNr == 1) return;
		FishNr = FishNr - 1;
		ShowFishNr(FishNr);
	}
	
	public void BuyFish()
	{
		if(player.FishStatus[FishNr - 1] == false)
		{
			if(player.Coins >= FishPrice[FishNr - 1])
			{
				player.Coins = player.Coins - FishPrice[FishNr - 1];
				player.FishStatus[FishNr - 1] = true;
				ShowFishNr(FishNr);
			}
			else
			{
				// not enough money
			}
		}
	}
	
	public void SelectThisFish()
	{
		if(player.FishStatus[FishNr - 1] == true)
		{
			player.SelectedFish = FishNr;
			ShowFishNr(FishNr);
		}
	}
	
	public void BackToMainMenu()
	{
		StartCoroutine(BackToMainMenuCoroutine());
	}
	
	IEnumerator BackToMainMenuCoroutine()
	{
		transition.SetTrigger("Start");
		
		yield return new WaitForSeconds(1f);
		
		SceneManager.LoadScene("MainMenu");
	}
	
	public void ShowFishNr(int fish_nr)
	{
		if(fish_nr > 15 || fish_nr < 1) return;
		if(player.FishStatus[fish_nr - 1] == true || fish_nr == 1)
		{
			Debug.Log("test TRUE");
			SpriteRenderer spriteRenderer;
			Sprite newSprite;
			string SpriteName;
			SpriteName = "Fish" + fish_nr.ToString();
			spriteRenderer = GetComponent<SpriteRenderer>();
			newSprite = Resources.Load<Sprite>(SpriteName);
			spriteRenderer.sprite = newSprite;
			statusText.text = "UNLOCKED";
			statusText.color = new Color(0.20f, 0.65f, 0.39f);
			buyButton.gameObject.SetActive(false);
			if(player.SelectedFish == fish_nr){
				selectButton.gameObject.SetActive(false);
				selectedText.gameObject.SetActive(true);
			}
			else{
				selectButton.gameObject.SetActive(true);
				selectedText.gameObject.SetActive(false);
			}
		}
		else
		{
			Debug.Log("test FALSE");
			SpriteRenderer spriteRenderer;
			Sprite newSprite;
			string SpriteName;
			SpriteName = "Fish" + fish_nr.ToString() + "Locked";
			spriteRenderer = GetComponent<SpriteRenderer>();
			newSprite = Resources.Load<Sprite>(SpriteName);
			spriteRenderer.sprite = newSprite;
			statusText.text = "LOCKED";
			statusText.color = new Color(0.65f, 0.21f, 0.21f);
			buyButton.GetComponentInChildren<TextMeshProUGUI>().text = "UNLOCK FOR " + FishPrice[fish_nr - 1].ToString() + " <sprite=0>";
			buyButton.gameObject.SetActive(true);
			selectButton.gameObject.SetActive(false);
			selectedText.gameObject.SetActive(false);
		}
		
	}
}
