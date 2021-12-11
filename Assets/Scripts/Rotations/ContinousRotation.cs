using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Rotations
{
    public class ContinousRotation : RotationBase
    {
        protected override bool LeftRotation()
        {
            return Input.GetKey(KeyCode.A);
        }

        protected override bool RightRotation()
        {
            return Input.GetKey(KeyCode.D);
        }
        
    }

}
