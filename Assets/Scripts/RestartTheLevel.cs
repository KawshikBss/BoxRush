using UnityEngine.SceneManagement;
using UnityEngine;

public class RestartTheLevel : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.R)) {
            RestartCurrentLevel();
        }
    }
    public void RestartCurrentLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
