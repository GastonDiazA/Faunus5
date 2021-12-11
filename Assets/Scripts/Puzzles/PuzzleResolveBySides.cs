using System;
using System.Collections;
using System.Collections.Generic;
using Rotations;
using UnityEngine;

public class PuzzleResolveBySides : PuzzleResolve
{ 
    private RotationBySidesLockable _rotation;

   protected override void Start(){
       
       base.Start();
       _rotation = GetComponent<RotationBySidesLockable>();
        
    }
}
