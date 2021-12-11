using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class CirclesPuzzleResolution : MonoBehaviour
{
  
    public UnityEvent OnPuzzleResolution = new UnityEvent();
   
   
    
    public void Win(){
        
        OnPuzzleResolution.Invoke();
    }
}
