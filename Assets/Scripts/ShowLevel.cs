using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class ShowLevel : MonoBehaviour
{
    private int currentLevel;
    void Start()
    {
        currentLevel = SceneManager.GetActiveScene().buildIndex;
        GetComponent<Text>().text = currentLevel.ToString();
    }
}
