using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NewB : MonoBehaviour
{
    public Transform endPoint;
    public float speed;
    public GameObject movingPart;

    public void onPointerClick(BaseEventData data)
    {
        Debug.Log("Success");
    }
   
   
}
