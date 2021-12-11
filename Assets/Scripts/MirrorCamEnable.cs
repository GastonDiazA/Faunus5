using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorCamEnable : MonoBehaviour
{
    public GameObject mirrorCamRef;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            mirrorCamRef.SetActive(true);
        }
    }
}
