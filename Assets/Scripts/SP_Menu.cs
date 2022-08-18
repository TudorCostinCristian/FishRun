using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SP_Menu : MonoBehaviour
{
	public Player player;
	public TextMeshProUGUI coinsText;

    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
    }

    void Update()
    {
        coinsText.text = player.Coins.ToString() + " <sprite=0>";
    }
}
