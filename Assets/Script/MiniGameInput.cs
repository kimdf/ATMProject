using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MiniGameInput : MonoBehaviour
{
    public string miniGameSceneName = "miniGame1";

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (CanEnterMiniGame()) 
            {
                SceneManager.LoadScene("miniGame1");
            }
        }
    }

    private bool CanEnterMiniGame()
    {
        return true;
    }

    public void Movescenemain()
    {
        SceneManager.LoadScene("DD");
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

