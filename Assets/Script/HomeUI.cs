using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeUI : BaseUI
{
    [SerializeField] private Button startButton;
    [SerializeField] private Button exitButton;

    public override void Init(UIManager uiManager)
    {
        base.Init(uiManager);
        startButton.onClick.AddListener(OnClickStartButton);
        exitButton.onClick.AddListener(OnClickExitButton);
    }

    public void OnClickStartButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MiniGameScene");
    }
    public void StartGame()
    {
        // 게임 시작 로직 (예: 미니게임 씬 로드)
        UnityEngine.SceneManagement.SceneManager.LoadScene("MiniGameScene");
    }
    public void OnClickExitButton()
    {
        Application.Quit();
    }

    //protected override UIState GetUIState()
    //{
    //    return UIState.Home;
    //}
}