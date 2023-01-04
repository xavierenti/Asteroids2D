using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int score;

    public Text ScoreText;

    private void Start()
    {
        score = 0;
        UpdateScore();
    }
        
    public void AddScore(int value){
        score += value;
        UpdateScore();
    }
    private void UpdateScore() {
        ScoreText.text = "Score: " + score; 
    }
}
