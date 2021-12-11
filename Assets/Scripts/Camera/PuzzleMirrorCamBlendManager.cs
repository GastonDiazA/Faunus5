using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;


public class PuzzleMirrorCamBlendManager : PuzzlesCamManager
{
    
    
    public GameObject refCamMirror;
    public GameObject objectToRotate1;
    public GameObject objectToRotate2;
    public GameObject objectToRotate3;
    //private ObjectRotation _rotation1;
    //private ObjectRotation _rotation2;
    //private ObjectRotation _rotation3;
    
    


    protected override void TurnOnOffPuzzle()
    {
        if (Input.GetKeyDown(KeyCode.C) && _thirdPersonCam.activeInHierarchy)
        {
            //Debug.Log("Puzzle cam ON.");
            _playerInput.enabled = false;
            //_particleSystem.Stop();
            _puzzleCam.SetActive(true);
            _thirdPersonCam.SetActive(false);
            refCamMirror.SetActive(true);
            // _rotation1.enabled = true;
            // _rotation2.enabled = true;
            // _rotation3.enabled = true;
        } 
        else if (Input.GetKeyDown(KeyCode.C) && !_thirdPersonCam.activeInHierarchy)
        {
            //Debug.Log("Puzzle cam OFF.");
            _playerInput.enabled = true;
            //_particleSystem.Play();
            _puzzleCam.SetActive(false);
            _thirdPersonCam.SetActive(true);
            // _rotation1.enabled = false;
            // _rotation2.enabled = false;
            // _rotation3.enabled = false;
        } 
    }
    
}