using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FootSteps : MonoBehaviour
{
    [SerializeField] private AudioClip[] _clips;

    private AudioSource _audioSource;

    
    void Awake()
    {
        _audioSource = GetComponent<AudioSource>();

    }

    public void Step()
    {
        AudioClip clip = GetRandomClip();
        _audioSource.PlayOneShot(clip);
    }

    private AudioClip GetRandomClip()
    {
        return _clips[UnityEngine.Random.Range(0, _clips.Length)];
    }
}
