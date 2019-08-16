using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Macheaderendpoint : MonoBehaviour
{
    public bool shouldMove = false;
    public Transform endPoint;
    public float speed;
    public GameObject Move;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        if (shouldMove == true)
        {


            Move.transform.position = Vector3.MoveTowards(Move.transform.position, endPoint.position, speed * Time.deltaTime);
        }

    }
    public void OnPointerDown()
    {
        shouldMove = true;


    }
}
