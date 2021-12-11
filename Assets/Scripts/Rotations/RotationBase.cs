using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rotations
{
	public abstract class RotationBase : MonoBehaviour
	{
		public int counterTab;
		[SerializeField] protected bool _axisSelector = true;
	    [SerializeField] protected bool _axisX = true;
	    [SerializeField] protected bool _axisY = true;
	    [SerializeField] protected bool _axisZ = true;
	    [SerializeField] protected float _speedRotation = 1f;
	    protected bool _isSelected = false;

	    protected bool _rotationLock;
		
		protected virtual void Start()
	    {               
			counterTab = 0;
	        Selectors();
	    
		}

		protected abstract bool LeftRotation();
		protected abstract bool RightRotation();

		

		protected void CounterReset()
	    {
	        if (counterTab == 3)
	        {
	            counterTab = 0;
	        }
	    }


		protected void Selectors()
		{
			if (!_axisSelector && !_axisX && !_axisZ)
			{
				counterTab = 1;
			}
			else if(!_axisSelector && !_axisX && !_axisY)
			{
				counterTab = 2;
			}
		}
	    
		
		
	    protected virtual void InputRotationManager()
	    {
	        if (_axisSelector && GetRotationInput())
	        {
	            counterTab++;
	        }
	        
	    }
		
		protected virtual bool GetRotationInput(){
			return Input.GetKeyDown(KeyCode.S);
		}
	    
		
	       

		protected virtual void Rotation(Vector3 dir)
		{
			if (_rotationLock)
			{
				return;
			}

			_rotationLock = true;
			LeanTween.rotateAroundLocal(gameObject, dir, 1,_speedRotation * Time.deltaTime).setOnComplete(() => { _rotationLock = false; });
			
		}
		
	    
		private void RotationX()
	    {
	        if (counterTab == 0 && _axisX)
	        {
	            if (RightRotation())
	            {
	                Rotation(Vector3.right);                               
	            } 
	            else if (LeftRotation())
	            {
	                Rotation(Vector3.left);
	            }
	            
	        }
	        
	    }

	    

	    private void RotationY()
	    {
	        if (counterTab == 1 && _axisY)
	        {
	            if (RightRotation())
	            {
	                Rotation(Vector3.up);
	            } 
	            else if (LeftRotation()) 
	            {
	                Rotation(Vector3.down);
	            }
	        }
	        
	    }

	    private void RotationZ()
	    {
	        if (counterTab == 2 && _axisZ)
	        {
	            
	            if (RightRotation())
	            {
	                Rotation(Vector3.forward);
	            } 
	            else if (LeftRotation())
	            {
	                Rotation(Vector3.back);
	            }
	        }
	    }

	    private bool IsAllowedToRotate(){
		    return _isSelected;
	    }
		
	    protected void OnTriggerExit(Collider other)
	    {
		    _isSelected = false;
	    }

	    public void MouseSelected (bool isSelected)
	    {
		    if(isSelected)
		    {
			    _isSelected = true;
		    }
		    else
		    {
			    _isSelected = false;
		    }
	    }

		
		

	    protected void Update()
	    {
		    LeftRotation();
		    RightRotation();
		    
		    if(IsAllowedToRotate()){
				
				CounterReset();
				InputRotationManager();
				RotationX();
				RotationY();
				RotationZ();
				
			}

	    }
	    
	}

}
