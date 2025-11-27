using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // UI 요소를 사용하기 위해 이 부분을 추가합니다.

public class MiniGameEndHandler : MonoBehaviour
{
    public int score; 

    public Text highScoreTextDisplay;

    public void EndMiniGame()
    {
        // 1. 현재 점수를 '마지막 점수'로 저장
        PlayerPrefs.SetInt("LastMiniGameScore", score);

        // 2. '최고 점수'를 확인하고 갱신
        // "HighScore"라는 이름으로 저장된 최고 점수가 없으면 0을 기본값으로 가져옵니다.
        int currentHighScore = PlayerPrefs.GetInt("HighScore", 0);

        if (score > currentHighScore)
        {
            PlayerPrefs.SetInt("HighScore", score);
            Debug.Log("🎉 New High Score: " + score);
            // ✨ 새로 추가: UI 텍스트에 새로운 최고 점수 표시
            if (highScoreTextDisplay != null) // 만약 UI 텍스트를 연결했다면
            {
                highScoreTextDisplay.text = "최고 점수: " + score.ToString();
            }
        }
        else
        {
            // ✨ 새로 추가: 새로운 최고 점수가 아닐 때도 현재 최고 점수를 UI에 표시
            if (highScoreTextDisplay != null) // 만약 UI 텍스트를 연결했다면
            {
                highScoreTextDisplay.text = "최고 점수: " + currentHighScore.ToString();
            }
        }

        // 3. 변경 사항 저장 (이 부분이 핵심!)
        // PlayerPrefs에 변경된 내용(마지막 점수, 최고 점수 등)을 저장합니다.
        // 이 코드가 있어야 게임을 다시 실행해도 점수가 유지돼요.
        PlayerPrefs.Save();

        // 4. 메인 맵으로 이동
        // 미니게임이 끝나면 "DD"라는 이름의 씬으로 이동합니다.
        SceneManager.LoadScene("DD");
    }
}