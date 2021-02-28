using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public float speed;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                GameResume();
            }
            else
            {
                GamePause();
            }
        }
    }

    public void GameResume()
    {
        pauseMenuUI.SetActive(false);
        Data.Instance.carSpeed = Data.Instance.gameSpeed;
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void GamePause()
    {
        pauseMenuUI.SetActive(true);
        Data.Instance.gameSpeed = Data.Instance.carSpeed;
        Data.Instance.carSpeed = 0;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }
}
