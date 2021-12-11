using System.Collections;
using System.Collections.Generic;
using Rotations;
using UnityEngine;

public class PuzzleResolveContinous : PuzzleResolve
{
    private ContinousRotationLockable _rotation;
    protected override void Start()
    {
        base.Start();
        _rotation = GetComponent<ContinousRotationLockable>();
        
        
    }


}
