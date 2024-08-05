using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;
    public int maxScore;

    public GameObject Score;
    public GameObject YouText;

    void Start()
    {
        score = 0;
    }

    public void AddScore(int newScore)
    {
        score += newScore;
    }

    public void UpdateScore()
    {
        scoreText.text = "Score " + score;
    }

     void Update()
    {
        UpdateScore();

        if (score == maxScore)
        {
            Score.SetActive(false);
            YouText.SetActive(true);
        }
    }
}