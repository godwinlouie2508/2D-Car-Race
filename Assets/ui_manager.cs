﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ui_manager : MonoBehaviour
{
    public Button[] buttons;
    public Text scoreText;
    int score;
    bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        score = 0;
        InvokeRepeating("scoreUpdate", 1.0f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
        
    }

    void scoreUpdate()
    {
        if (gameOver == false)
        {
            score += 1;
        }
    }
    public void gameOverActivated()
    {
        gameOver = true;
        foreach(Button button in buttons)
        {
            button.gameObject.SetActive(true);
        }
    }

    public void play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
    public void pause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }

    public void Replay()
    {
        SceneManager.LoadScene("level1");
    }
    
    public void Menu()
    {
        SceneManager.LoadScene("menu_scene");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
