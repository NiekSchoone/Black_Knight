﻿//Written by Niek Schoone
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField]
    private GameObject menu;
    private GameObject replay;
    private GameObject gameOverText;

    void Awake()
    {
        menu = GameObject.Find("MenuButton");
        replay = GameObject.Find("ReplayButton");
        gameOverText = GameObject.Find("GameOverText");
    }

    public void EndGame()
    {
        Application.LoadLevel(0);
        menu.SetActive(true);
        replay.SetActive(true);

        gameOverText.SetActive(true);
    }
}
