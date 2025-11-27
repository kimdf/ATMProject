using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject gameOverMenu;

    public void Start()
    {
        if (gameOverMenu == null)
        {
            
        }

        if (scoreText == null)
        {
           
            return;
        }

        gameOverMenu.gameObject.SetActive(false);
    }

    public void SetRestart()
    {
        gameOverMenu.gameObject.SetActive(true);

    }

    public void UpdateScore(int score)
    {
       
        scoreText.text = score.ToString();
    }
}