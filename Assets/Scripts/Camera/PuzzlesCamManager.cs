using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using Rotations;
using TargetPlatforms;
using UnityEngine;


public class PuzzlesCamManager : MonoBehaviour
{
    [SerializeField] protected GameObject _puzzleCam;
    [SerializeField] protected GameObject _thirdPersonCam;
    protected PlayerInput _playerInput;
    protected ParticleSystem _particleSystem;
    public GameObject puzzleManager;

    private TargetPlatformBase [] _targetPlatformBases; 
    

    [SerializeField] private bool _isTouching;
    
    void Start()
    {
        _playerInput = FindObjectOfType<PlayerInput>();

        _particleSystem = GetComponent<ParticleSystem>();

        _targetPlatformBases = puzzleManager.GetComponents<TargetPlatformBase>();



    }

    
    void Update()
    {
        if (_isTouching)
        {
            TurnOnOffPuzzle();
        }
    }

    protected virtual void TurnOnOffPuzzle()
    {
        if (Input.GetMouseButton(0) && _thirdPersonCam.activeInHierarchy)
        {
            //Debug.Log("Puzzle cam ON.");
            _playerInput.enabled = false;
            _particleSystem.Stop();
            _puzzleCam.SetActive(true);
            _thirdPersonCam.SetActive(false);
            
            // for (int i = 0; i < _targetPlatformBases.Length; i++)
            // {
            //     _targetPlatformBases[i].enabled = true;
            //
            // }
            
        } 
        else if (Input.GetMouseButton(0) && !_thirdPersonCam.activeInHierarchy)
        {
            //Debug.Log("Puzzle cam OFF.");
            _playerInput.enabled = true;
            _particleSystem.Play();
            _puzzleCam.SetActive(false);
            _thirdPersonCam.SetActive(true);
            for (int i = 0; i < _targetPlatformBases.Length; i++)
            {
                _targetPlatformBases[i].enabled = false;

            }
        } 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Entre al puzzle desde el padre");
            _isTouching = true;
        }
    }
    
    

 
    
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Salí del puzzle desde el padre.");
            _isTouching = false; 
            _thirdPersonCam.SetActive(true);
            
        }
        
    }

    public void NormalMovement()
    {
        _thirdPersonCam.SetActive(true);
        _playerInput.enabled = true;
    }
}
