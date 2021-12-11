using System.Collections;
using System.Collections.Generic;
using Rotations;
using UnityEngine;

public class ContinousRotationLockable : ContinousRotation, ILockable
{
    protected override void Start()
    {
        base.Start();
        PuzzleResolve puzzleResolve = transform.GetComponent<PuzzleResolve>();
        puzzleResolve.OnPuzzleResolve.AddListener(LockRotation);
    }
    public void LockRotation(PuzzleResolve puzzle)
    {
        Destroy(this);
    }
}
