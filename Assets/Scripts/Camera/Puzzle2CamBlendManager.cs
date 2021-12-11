using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle2CamBlendManager : PuzzlesCamManager
{
    public GameObject objectToRotate;
    //private ContinousRotation _rotation1;

    void Start()
    {
        _playerInput = FindObjectOfType<PlayerInput>();
       // _particleSystem = GetComponent<ParticleSystem>();
        //_rotation1 = objectToRotate.GetComponent<ContinousRotation>();
    }
    protected override void TurnOnOffPuzzle()
    {   
        if(Input.GetKeyDown(KeyCode.C) && _thirdPersonCam.activeInHierarchy)
        {
            //Debug.Log("Puzzle cam ON.");
            Debug.Log("Entre al puzzle desde el hijo.");
            _playerInput.enabled = false;
           //_particleSystem.Stop();
            _puzzleCam.SetActive(true);
            _thirdPersonCam.SetActive(false);
            //_rotation1.enabled = true;

        } 
        else if (Input.GetKeyDown(KeyCode.C) && !_thirdPersonCam.activeInHierarchy)
        {
            //Debug.Log("Puzzle cam OFF.");
            Debug.Log("Sali del puzzle desde el hijo.");
            _playerInput.enabled = true;
            //  _particleSystem.Play();
            _puzzleCam.SetActive(false);
            _thirdPersonCam.SetActive(true);
            //_rotation1.enabled = false;
            

        } 
        
    }
    
    
}
