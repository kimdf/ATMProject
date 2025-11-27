using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MiniGame : MonoBehaviour
{
    public string miniGameSceneName = "miniGame1";

    private void Update()
    {
      
    }

    private bool CanEnterMiniGame()
    {
        return true;
    }

    public void Movescenemain()
    {
        SceneManager.LoadScene("miniGame1");
    }
    public void SetRestart()
    {
        Button button = GetComponent<Button>();

    }
    private void EnterMiniGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(miniGameSceneName);
    }
}

