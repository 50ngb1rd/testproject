using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YenniRobotMovement : MonoBehaviour
{
    public bool canTurn = false;
    public bool canMove = false;
    public float speed;
    
    public Transform Final;
    // Start is called before the first frame update
    

    // Update is called once per frame
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
