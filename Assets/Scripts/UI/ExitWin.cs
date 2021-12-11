using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitWin : MonoBehaviour
{
    public GameObject winExitMenu;
    
    void Start()
    {
        
    }

    


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0f;
            winExitMenu.SetActive(true);
            

        }
    }
}
