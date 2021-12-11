using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleColumnsManager : PuzzlesCamManager
{
    public GameObject objectToRotate1;
    public GameObject objectToRotate2;
    public GameObject objectToRotate3;
    //private ContinousRotationWithSelect _rotation1;
    //private ContinousRotationWithSelect _rotation2;
    //private ContinousRotationWithSelect _rotation3;

    void Start()
    {
        _playerInput = FindObjectOfType<PlayerInput>();
        //_particleSystem = GetComponentInChildren<ParticleSystem>();
        //_rotation1 = objectToRotate1.GetComponent<ContinousRotationWithSelect>();
        //_rotation2 = objectToRotate2.GetComponent<ContinousRotationWithSelect>();
        //_rotation3 = objectToRotate3.GetComponent<ContinousRotationWithSelect>();

    }

    protected override void TurnOnOffPuzzle()
    {
        if (Input.GetKeyDown(KeyCode.C) && _thirdPersonCam.activeInHierarchy)
        {
            //Debug.Log("Puzzle cam ON.");
            _playerInput.enabled = false;
            //_particleSystem.Stop();
            _puzzleCam.SetActive(true);
            _thirdPersonCam.SetActive(false);
            //_rotation1.enabled = true;
            //_rotation2.enabled = true;
           // _rotation3.enabled = true;
        } 
        else if (Input.GetKeyDown(KeyCode.C) && !_thirdPersonCam.activeInHierarchy)
        {
            //Debug.Log("Puzzle cam OFF.");
            _playerInput.enabled = true;
            //_particleSystem.Play();
            _puzzleCam.SetActive(false);
            _thirdPersonCam.SetActive(true);
            //_rotation1.enabled = false;
            //_rotation2.enabled = false;
            //_rotation3.enabled = false;
        } 
        
    }
        
    
    
    
}
