using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AudioSystem
{
    

    public abstract class AudioAdapter : ScriptableObject
    {
        public abstract void Load(GameObject owner);
        
        public abstract void Play(bool isLoop = false);
        
        public abstract void Pause();
        
        public abstract void Stop();
        
        public abstract void SetVolume(float volume);

    }

}
