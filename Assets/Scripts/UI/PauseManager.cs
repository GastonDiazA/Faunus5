using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MainMenuManager
{
    public static bool gameItsPaused;
    public GameObject pauseMenuUI;

    private void Awake()
    {
        gameItsPaused = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameItsPaused)
            {
                Resume();  
            }else
            {
                Pause();
            }
           
        }
        
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        gameItsPaused = false;
        Time.timeScale = 1f;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        gameItsPaused = true;
        Time.timeScale = 0f;
    }
    
}
