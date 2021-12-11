using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController characterController;
        
    //MOVE
    [SerializeField] private float _speed = 6f;
    private float _horizontalMove;
    private float _verticalMove;
    private Vector3 _playerInputVector3;
    public Vector3 _movePlayer;
    private float _targetAngle;
    private float _turnSmoothVelocity;
    private PlayerInput _playerInput;
    
    //GRAVITY + JUMP
    public float gravity = 9.8f;
    public float fallVelocity;
    public bool isJump;
    public float jumpSpeed;
    private int _jumpCounter;
    [SerializeField] private int _jumpsLimit = 1;
    public float impulseForce = 5f;
    private bool _isTouchingImpulse = false;
    public Transform startPos;
    //CAM
    public Camera mainCamera;
    private Vector3 _camForward;
    private Vector3 _camRight;
    //ANIMATOR
    public CharacterAnimatorController animatorController;


    private void Start()
    {
        _playerInput = GetComponent<PlayerInput>();

    }

    // Update is called once per frame
    void Update()
    {
        _horizontalMove = _playerInput._horizontalMove;
        _verticalMove = _playerInput._verticalMove;
        _playerInputVector3 = new Vector3(_horizontalMove, 0.0f, _verticalMove).normalized;
    
       
        
        
        _playerInputVector3 = Vector3.ClampMagnitude(_playerInputVector3, 1);
        CamDirection();

        _movePlayer = _playerInputVector3.x * _camRight  + _playerInputVector3.z * _camForward;

        _movePlayer *= _speed;  

        characterController.transform.LookAt(characterController.transform.position + _movePlayer);

        SetGravity();

        Jump();
        
        ImpulseByPlatform();

        characterController.Move(_movePlayer * Time.deltaTime);

        if (_horizontalMove != 0 || _verticalMove != 0 && _playerInput.isActiveAndEnabled)
        {
            animatorController?.SetSpeed(1);
            
        }else 
        {
            animatorController?.SetSpeed(0);
        }
        
        
    }
    
    private void SetGravity(){
        if(characterController.isGrounded){
            fallVelocity = -gravity * Time.deltaTime;
            _movePlayer.y = fallVelocity;
            _jumpCounter = 0;
        }else{
            fallVelocity -= gravity * Time.deltaTime;
            _movePlayer.y = fallVelocity;
        }

    }
    
    private void CamDirection(){
        var transform1 = mainCamera.transform;
        _camForward = transform1.forward;
        _camRight = transform1.right;

        _camForward.y = 0f;
        _camRight.y = 0f;

        _camForward = _camForward.normalized;
        _camRight = _camRight.normalized;

    }

    private void Jump(){
        isJump = Input.GetButtonDown("Jump");

        if(isJump && _jumpCounter < _jumpsLimit){
            animatorController?.Jump();
            fallVelocity = jumpSpeed;
            _movePlayer.y = fallVelocity;
            _jumpCounter ++;

        }
    }


    private void OnControllerColliderHit(ControllerColliderHit hit){
        if(hit.gameObject.CompareTag("ImpulsePlatform")){
            _isTouchingImpulse = true;
            fallVelocity = impulseForce;
            _movePlayer.y = fallVelocity;
        }

        if (hit.gameObject.CompareTag("Death"))
        {
            Invoke(nameof(Death), 0.2f * Time.deltaTime);  
        }

        if (hit.gameObject.CompareTag("Portal"))
        {
            //SceneManager.LoadScene("Level_1");
        }

        if (hit.gameObject.CompareTag("Bullet"))
        {
            Destroy(hit.gameObject);
        }
    }

    private void ImpulseByPlatform(){
        if(_isTouchingImpulse){
            fallVelocity = impulseForce;
            _movePlayer.y = fallVelocity;
            _isTouchingImpulse = false;
            animatorController?.Jump();

        }
    }

    private void Death()
    {
        transform.position = startPos.position;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Death"))
        {
            
           transform.position = startPos.position;
        }
    }

    
}
