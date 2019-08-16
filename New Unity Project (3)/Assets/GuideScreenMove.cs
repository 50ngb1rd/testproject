using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuideScreenMove : MonoBehaviour
{
    public bool canMove = false;
    public Transform Final;
    void Update()
    {
        

        if (canMove == true)
        {
            this.transform.position = Final.position;
            this.transform.rotation = Final.rotation;
        }
    }


    public void TurnHead()
    {
        
        canMove = true;
    }
}
