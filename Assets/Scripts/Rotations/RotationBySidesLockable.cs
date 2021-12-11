using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Rotations
{
    public class RotationBySidesLockable : RotationBySides, ILockable
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
}
