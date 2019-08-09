using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class YenniMoveToSpot : MonoBehaviour
{
    public GameObject monitor;
    public GameObject leftDoor;
    public GameObject rightDoor;
      
   
    
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
       
    }

    public IEnumerator Movement()
    {
        //monitor.transform.Rotate(0f, -45.65f, 0f);
        //monitor.transform.position = Vector3.MoveTowards(monitor.transform.position, endPoint.transform.position, speed * Time.deltaTime);
        // monitor.transform.Translate(-5.43f * speed * Time.deltaTime, 0, -1.51f * speed * Time.deltaTime);
        Vector3 newPosition = new Vector3(0, 4.8f, 0);
        //monitor.transform.position += newPosition * speed * Time.deltaTime;
        yield return StartCoroutine(MoveObject.use.Translation(monitor.transform, newPosition, 3f, MoveObject.MoveType.Time));
    }

    public IEnumerator LeftDoorMovement()
    {
        //monitor.transform.Rotate(0f, -45.65f, 0f);
        //monitor.transform.position = Vector3.MoveTowards(monitor.transform.position, endPoint.transform.position, speed * Time.deltaTime);
        // monitor.transform.Translate(-5.43f * speed * Time.deltaTime, 0, -1.51f * speed * Time.deltaTime);
        Vector3 newPosition = new Vector3(0, 0, -0.3f);

        //monitor.transform.position += newPosition * speed * Time.deltaTime;
        yield return StartCoroutine(MoveObject.use.Translation(leftDoor.transform, newPosition, 3f, MoveObject.MoveType.Time));
       
    }

    public IEnumerator RightDoorMovement()
    {
        Vector3 newPositionRight = new Vector3(0, 0, 0.4f);
        yield return StartCoroutine(MoveObject.use.Translation(rightDoor.transform, newPositionRight, 3f, MoveObject.MoveType.Time));

    }

    


    public void onButtonCLicked()
    {
        
        
            StartCoroutine(Movement());
        
        
    }
    
    public void OnDLButton1CLicked()
    {
        StartCoroutine(LeftDoorMovement());
        
    }

    public void onDLButton2Clicked()
    {

        StartCoroutine(RightDoorMovement());
    }
    
    public void OnButton2CLicked()
    {
        

            StartCoroutine(Movement());

        
    }


}
