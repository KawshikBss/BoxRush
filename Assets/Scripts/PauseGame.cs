using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject pauseButton;
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape)) {
            if (!gameIsPaused)
                Pause();
        }
    }

    public void Resume() {
        pauseMenuUI.SetActive(false);
        pauseButton.SetActive(true);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    public void Pause() {
        Time.timeScale = 0f;
        pauseMenuUI.SetActive(true);
        pauseButton.SetActive(false);
        gameIsPaused = true;
    }
    public void Menu() {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
    public void QuitGame() {
        Application.Quit();
    }
}
