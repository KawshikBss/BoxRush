using UnityEngine.UI;
using UnityEngine;

public class FinalScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().text = PlayerPrefs.GetInt("Score", 0).ToString();
        PlayerPrefs.DeleteKey("Score");
    }
}
