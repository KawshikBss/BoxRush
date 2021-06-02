using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameOver = false;
    public float delay = 2f;

    public GameObject completeMessage;
    public GameObject overMessage;
    public GameObject score;
    public int currentScore;

    public void CompleteLevel() {
        if (!gameOver) {
            gameOver = true;
            currentScore = score.GetComponent<Score>().score;
            PlayerPrefs.SetInt("Score", currentScore + PlayerPrefs.GetInt("Score", 0));
            completeMessage.SetActive(true);
        }
    }

    public void CompleteGame() {
        if (!gameOver) {
            gameOver = true;
            completeMessage.SetActive(true);
        }
    }

    public void EndGame() {
        if (!gameOver) {
            gameOver = true;
            GameObject.FindObjectOfType<Score>().enabled = false;
            score.SetActive(false);
            PlayerPrefs.SetInt("Score", 0);
            overMessage.SetActive(true);
            Invoke("Restart", delay);
        }
    }

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
