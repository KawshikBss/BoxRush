using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();
    }

    void OnTriggerEnter()
    {
        if (SceneManager.GetActiveScene().buildIndex == 15)
            gameManager.CompleteGame();
        else
            gameManager.CompleteLevel();
    }
}
