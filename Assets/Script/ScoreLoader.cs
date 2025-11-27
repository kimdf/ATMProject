using UnityEngine;
using TMPro; 

public class ScoreLoader : MonoBehaviour
{
    
    public TextMeshProUGUI scoreDisplay;

    // PlayerPrefs에 저장했던 키 이름
    public const string LAST_SCORE_KEY = "LastMiniGameScore";


    void Start()
    {
        LoadAndDisplayScores();        
    }

    private void LoadAndDisplayScores()
    {
        // 1. 마지막 점수 불러오기
        int lastScore = PlayerPrefs.GetInt(LAST_SCORE_KEY, 0);


  

            if (scoreDisplay != null)
        {
            scoreDisplay.text =
                $"Last Score: {lastScore}\n";
        }
        else
        {
            
        }
    }
}