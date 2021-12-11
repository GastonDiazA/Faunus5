using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;

public class Puzzle1Resolution : MonoBehaviour
{
    
    private PlayableDirector _playableDirector;
    public PlayableAsset TimeLinePlayableAsset;
    
    
    public UnityEvent OnPuzzleResolution = new UnityEvent();

    private void Start()
    {
        _playableDirector = FindObjectOfType<PlayableDirector>();
        
    }

    public void ResolutionAnimation()
    {
        _playableDirector.Play(TimeLinePlayableAsset);
        OnPuzzleResolution.Invoke();
        StartCoroutine("DestroyPuzzle", _playableDirector.duration + 1);
    }

    IEnumerator DestroyPuzzle(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Destroy(gameObject);
    }
}
