using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitWin : MonoBehaviour
{
    public GameObject winExitMenu;
    

    public void Win()
    {
        Time.timeScale = 0f;
        winExitMenu.SetActive(true);
        
    }
    
}
