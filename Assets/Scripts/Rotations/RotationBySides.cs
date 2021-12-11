using System.Collections;
using System.Collections.Generic;
using Rotations;
using UnityEngine;

namespace Rotations
{
    

    public class RotationBySides : RotationBase
    {
        [SerializeField] private float _degreesToRotate;
        [SerializeField] private float sidesOfThePiece;
    

        protected override bool LeftRotation()
        {
            return Input.GetKeyDown(KeyCode.A);
        }

        protected override bool RightRotation()
        {
            return Input.GetKeyDown(KeyCode.D);
        }

        protected override void Start()
        {
            base.Start();
            _degreesToRotate = 360.0f / sidesOfThePiece;
        }
    
    
        protected override void Rotation(Vector3 dir)
        {
            if (_rotationLock)
            {
                return;
            }
            _rotationLock = true;
            LeanTween.rotateAroundLocal(gameObject, dir, _degreesToRotate,_speedRotation * Time.deltaTime).setOnComplete(() => { _rotationLock = false; });
            
        }

    }

}
