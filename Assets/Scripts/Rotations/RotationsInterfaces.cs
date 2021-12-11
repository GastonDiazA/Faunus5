using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rotations
{
    public interface ILockable
        {
            void LockRotation(PuzzleResolve puzzle);
        }

}
