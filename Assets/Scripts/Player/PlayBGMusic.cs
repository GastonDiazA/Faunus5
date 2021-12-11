using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AudioSystem;

public class PlayBGMusic : MonoBehaviour
{
    [SerializeField] private GameObject _audioAdapter;
    private AudioController _audioController;
     void Start()
     {
         _audioController = _audioAdapter.GetComponent<AudioController>();
         _audioController.SetVolume(0.1f);
        _audioController.Play(true);
        
    }

}
