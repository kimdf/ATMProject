using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static GameManager gameManager;

    public GameObject gameOverUI;

    public static GameManager Instance
    {
        get { return gameManager; }
    }

    private int currentScore = 0;
    UIManager uiManager;

    public UIManager UIManager
    {
        get { return uiManager; }
    }

    public static object instance { get; internal set; }

    private void Awake()
    {
        gameManager = this;
        uiManager = FindObjectOfType<UIManager>();
    }

    private void Start()
    {
        gameOverUI.SetActive(false);
       //uiManager.UpdateScore(0);
    }

    public void GameOver()
    {
        Debug.Log("Game Over");
        gameOverUI.SetActive(true);
        uiManager.SetRestart();
        PlayerPrefs.SetInt( ScoreLoader.LAST_SCORE_KEY , currentScore);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("miniGame1");
    }

    public void AddScore(int score)
    {
        currentScore += score;
        uiManager.UpdateScore(currentScore);
        Debug.Log("Score: " + currentScore);
    }

}