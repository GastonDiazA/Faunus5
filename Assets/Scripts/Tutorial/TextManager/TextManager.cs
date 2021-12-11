using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public Image ColliderMoveTutorial_img;
    public Image ColliderJumpTutorial_img;
    public Image ColliderPuzzleCamSolvetutorial_img;
   

    void Start()
    {
        ColliderMoveTutorial_img.enabled = false;
        ColliderJumpTutorial_img.enabled = false;
        ColliderPuzzleCamSolvetutorial_img.enabled = false;
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "ColliderMoveTutorial")
        {
            ColliderMoveTutorial_img.enabled = true;
        }
        if (other.gameObject.name == "ColliderJumpTutorial")
        {
            ColliderJumpTutorial_img.enabled = true;
        }
        if (other.gameObject.name == "ColliderPuzzleCamSolvetutorial")
        {
            ColliderPuzzleCamSolvetutorial_img.enabled = true;
        }
       
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "ColliderMoveTutorial")
        {
            ColliderMoveTutorial_img.enabled = false;
        }
        if (other.gameObject.name == "ColliderJumpTutorial")
        {
            ColliderJumpTutorial_img.enabled = false;
        }
        if (other.gameObject.name == "ColliderPuzzleCamSolvetutorial")
        {
            ColliderPuzzleCamSolvetutorial_img.enabled = false;
        }
    }
}