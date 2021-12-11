using System.Collections;
using System.Collections.Generic;
using AudioSystem;
using UnityEngine;

namespace AudioSystem
{
   public class AudioController : MonoBehaviour
    {
        [SerializeField] private AudioAdapter _audioAdapter;

        private void Awake()
        {
            _audioAdapter.Load(gameObject);
        }

        public void Play(bool loop)
        {
            _audioAdapter.Play(loop);
        }

        public void Stop()
        {
            _audioAdapter.Stop();
        }
        
        public void Pause()
        {
            _audioAdapter.Pause();
        }
        
        public void SetVolume(float volume)
        {
            _audioAdapter.SetVolume(volume);
        }

    }
}
