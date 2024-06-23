using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class GameController : MonoBehaviour
{
    public int totalScore;
    public Text scoreText;
    public GameObject gameOver;
    public static GameController instance;
    
    void Awake()
    {
        instance = this;
    }

    void Start()
    {/*
        if (scoreText == null)
        {
            Debug.LogError("scoreText não está atribuído no Inspector.");
        }
        if (gameOver == null)
        {
            Debug.LogError("gameOver não está atribuído no Inspector.");
        }
        else
        {
            gameOver.SetActive(false); 
        }*/
    }

    public void UpdateScoreText() 
    {
        if (scoreText != null)
        {
            scoreText.text = totalScore.ToString();
        }
        else
        {
            Debug.LogError("scoreText não está atribuído no Inspector.");
        }
    }

    public void ShowGameOver() 
    {
        if (gameOver != null)
        {
            gameOver.SetActive(true); // Ativa a tela de Game Over
        }
        else
        {
            Debug.LogError("gameOver não está atribuído no Inspector.");
        }
    }
    public void RestartGame(String lvlName)
    {
        SceneManager.LoadScene(lvlName);
    }
    
}
