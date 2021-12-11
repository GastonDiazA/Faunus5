using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryRotations : MonoBehaviour
{
    private Quaternion _currentRotation;
    public float degrees;
    

    private void Start()
    {
        
    }


    void Update()
    {
        _currentRotation = transform.rotation;
        if (Input.GetKeyDown(KeyCode.E))
        {
            for (int i = 0; i < degrees; i++)
            {
                transform.rotation = Quaternion.Euler(_currentRotation.x++, _currentRotation.y, _currentRotation.x);
            }
            
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            for (int i = 0; i < degrees; i++)
            {
                transform.rotation = Quaternion.Euler(_currentRotation.x--, _currentRotation.y, _currentRotation.x);
            }
            
        }
        
    }
}
