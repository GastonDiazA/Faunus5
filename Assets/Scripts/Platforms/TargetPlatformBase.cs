using System;
using System.Collections;
using System.Collections.Generic;
using Rotations;
using UnityEditor;
using UnityEngine;


namespace TargetPlatforms
{
    public class TargetPlatformBase : MonoBehaviour

{
   // private Renderer _renderer;
   
    //public GameObject puzzleManager;
    private RotationBase _objectRotation;
    private Color _currentColor;
    private Transform _selection;
    [SerializeField] private LayerMask _layerMaks;


    private void Update()
    {
        if (_selection != null)
        {
            var selectionRenderer = _selection.GetComponent<Renderer>();
            selectionRenderer.material.color = _currentColor;
            _selection = null;
        }
        
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, _layerMaks))
        {
            var selection = hit.transform;
            if (selection.CompareTag("Selectable"))
            {
                _objectRotation.MouseSelected(true);
                var selectionRenderer = selection.GetComponent<Renderer>();
                selectionRenderer.material.color = Color.yellow;
                _selection = selection;
            }
        }
        else
        {
            _objectRotation.MouseSelected(false); 
        }
    }

    void Start()
    {
        _objectRotation = GetComponentInParent<RotationBase>();

    }

}
    
}
