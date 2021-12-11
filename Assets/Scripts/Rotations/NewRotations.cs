using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode]
public class NewRotations : MonoBehaviour
{
    public Transform starPosition;
    public Transform endPosition;
    private Quaternion _currentRotation;
    public float degrees;
    public float lerpSlider = 2f;
    public float distanceToSleerp;

    [SerializeField] private int sidesOfThePiece;
    private float _degreesToRotate;
    private float _rotation;




    private void Start()
    {
        _degreesToRotate = 360.0f / sidesOfThePiece;
        
        


    }

    void Update()
    {
        
        
        
        _currentRotation = transform.rotation;
        var _rotationPos = _currentRotation.eulerAngles.x + 90.0f;
        var _rotationNeg = transform.rotation.eulerAngles.x - 90.0f; 
        if (Input.GetKeyDown(KeyCode.E))
        {
            
            LeanTween.rotateAroundLocal(gameObject, Vector3.right, _degreesToRotate,lerpSlider);
            //LeanTween.rotateLocal(gameObject, new Vector3(_rotationPos, _currentRotation.y, _currentRotation.z), lerpSlider);
            //LeanTween.rotateX(gameObject, _currentRotation.x + 90.0f, lerpSlider);


        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            LeanTween.rotateAroundLocal(gameObject, Vector3.left , _degreesToRotate,lerpSlider);
            //LeanTween.rotateLocal(gameObject, new Vector3(_rotationNeg, _currentRotation.y, _currentRotation.z), lerpSlider);
            //LeanTween.rotateX(gameObject, _currentRotation.x - 90.0f, lerpSlider);
            
        }
        
    }
    private void BridgeMovement()
    {
        
        Vector3 movement1 = new Vector3(transform.position.x, transform.position.y,
            transform.position.z + distanceToSleerp);
        transform.position = Vector3.Lerp(starPosition.position, endPosition.position,  lerpSlider * Time.deltaTime * 0.01f);
    }
}
