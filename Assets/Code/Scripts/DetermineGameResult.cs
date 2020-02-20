﻿using UnityEngine;

public class DetermineGameResult : MonoBehaviour
{
    void Start()
    {
        // todo: consider doing the change through on state change, similar to the in-game score labels
        var endMenuMainTitle = GameObject.Find("Title").GetComponent<TMPro.TextMeshProUGUI>();
        var endMenuSubtitle = GameObject.Find("Subtitle").GetComponent<TMPro.TextMeshProUGUI>();

        endMenuMainTitle.text = GameData.player1Score == GameData.winningScore ? "Game Won" : "Game Lost";
        endMenuSubtitle.text = GameData.player1Score.ToString() + " - " + GameData.player2Score.ToString();
    }
}
