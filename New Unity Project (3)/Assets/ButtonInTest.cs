using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonInTest : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool shouldMove = false;
    public Transform endPoint;
    public float speed;
    public Vector3 oriPoint;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        if (shouldMove == true)
        {


            this.transform.position = Vector3.MoveTowards(this.transform.position, endPoint.position, speed * Time.deltaTime);
        }
       else if(shouldMove == false)
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, oriPoint, speed * Time.deltaTime);
        }
        
    }

    public void OnPointerDown(PointerEventData data1)
    {
        shouldMove = true;
        
        
    }

    public void OnPointerUp(PointerEventData data1)
    {
        shouldMove = false;
    }

   

    
}
