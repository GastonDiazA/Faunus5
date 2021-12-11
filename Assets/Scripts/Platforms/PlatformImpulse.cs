using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformImpulse : MonoBehaviour
{
    [SerializeField] private float _impulseForce = 12;
    private ImpulseByPlatform _impulseByPlatform;


    private void Start()
    {
        _impulseByPlatform = FindObjectOfType<ImpulseByPlatform>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log($"Toque al personaje.");
            _impulseByPlatform.ReciveImpulse(_impulseForce);
        }
    }
}
