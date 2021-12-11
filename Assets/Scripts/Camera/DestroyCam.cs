using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCam : MonoBehaviour
{

    public void DestroyCamera(float waitTime)
    {
        StartCoroutine("DestroyCamCoroutine", waitTime);
        
    }

    IEnumerator DestroyCamCoroutine(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        gameObject.SetActive(false);
        
        
        
    }
}
