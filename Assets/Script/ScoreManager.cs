using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance = null;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }

    public Text currentScoreUI;

    private int currentScore;

    public Text bestScoreUI;

    private int bestScore;

  
    void Start()
    {
        bestScore = PlayerPrefs.GetInt("Best Score", 0);

        bestScoreUI.text = "최고점수 " + bestScore;
    }

   
    void Update()
    {
        
    }

    public int Score
    {
        get
        {
            return currentScore;
        }
        set
        {
            currentScore = value;

            currentScoreUI.text = "현재점수 " + currentScore;


            if (currentScore > bestScore)
            {
                bestScore = currentScore;

                bestScoreUI.text = "최고점수 " + bestScore;

                PlayerPrefs.SetInt("Best Score", bestScore);
            }
        }
    }
}
