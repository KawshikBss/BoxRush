using UnityEngine.SceneManagement;
using UnityEngine;

public class Credits : MonoBehaviour
{
    public void PlayAgain() {
        SceneManager.LoadScene(1);
    }

    public void Quit() {
        Application.Quit();
    }
}
