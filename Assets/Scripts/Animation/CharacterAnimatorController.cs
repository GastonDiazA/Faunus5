using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimatorController : MonoBehaviour
{
    private const string _MOTION = "Motion";
    private const string _JUMP = "Jump";
    private Animator _animator;
    void Start()
    {
        _animator = GetComponent<Animator>();

    }
    
    //Set motion animation, idle = 0 / walk or run = 1;
    
    public void SetSpeed(float speed)
    {
        _animator.SetFloat(_MOTION, speed);
    }
    public void Jump()
    {
        _animator.SetTrigger(_JUMP);
    }
    
    
}
