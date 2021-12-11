using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;

public class AllPuzzlesResolve : MonoBehaviour
{
    public static int allPuzzlesResolved;
    public UnityEvent AllPuzzlesAreResolved = new UnityEvent();
    private List<PuzzleResolve> _puzzles = new List<PuzzleResolve>();
    
    
    
    
    
    
    void Start()
    {
        
        PuzzleResolve [] puzzleResolve = transform.GetComponentsInChildren<PuzzleResolve>();
        allPuzzlesResolved = puzzleResolve.Length;
        for (int i = 0; i < allPuzzlesResolved; i++)
        {
            puzzleResolve[i].OnPuzzleResolve.AddListener(countPuzzlesSolved);
            _puzzles.Add(puzzleResolve[i]);
            
        }
        

    }
    

    public void countPuzzlesSolved(PuzzleResolve puzz)
    {
        Debug.Log("Entro el puzzle.");
        if (_puzzles.Contains(puzz))
        { 
            Debug.Log("Entro el puzzle 1 vez.");
            _puzzles.Remove(puzz);
        allPuzzlesResolved--;
        if (_puzzles.Count <= 0)
        {
            AllPuzzlesAreResolved.Invoke();
            
        }
        }

    }


}
