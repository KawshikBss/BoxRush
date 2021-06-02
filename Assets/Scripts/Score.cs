using UnityEngine;
using UnityEngine.UI;
using System;

public class Score : MonoBehaviour
{
    public Transform playerTransform;
    public Text scoreText;

    public int score;
    private int highScore;
    
    void Start() {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
    }

    // Update is called once per frame
    void Update()
    {
        score = Convert.ToInt32(playerTransform.position.z);
        if (score > highScore)
            PlayerPrefs.SetInt("HighScore", score);
        scoreText.text = score.ToString("0");
    }
}
