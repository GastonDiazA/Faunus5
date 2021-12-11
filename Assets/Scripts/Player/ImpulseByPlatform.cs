using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpulseByPlatform : MonoBehaviour
{
    private PlayerController _player;
    private float _playerFallVelocity;
    private float _impulseForce;
    void Start()
    {
        _player = GetComponent<PlayerController>();
        _playerFallVelocity = _player.fallVelocity;
    }

    private void Update()
    {
        ImpulseCharacter(_impulseForce);
        
    }

    public void ReciveImpulse(float impulse)
    {
        _impulseForce = impulse;
        Debug.Log($"Recibi el impulso");
    }
    public void ImpulseCharacter(float impulseForce)
    {
        _playerFallVelocity = impulseForce;
        _player._movePlayer.y = _playerFallVelocity;
        
    }
}
