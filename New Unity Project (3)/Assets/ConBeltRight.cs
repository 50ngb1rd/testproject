using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ConBeltRight : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public float speed;
    public GameObject TargetObject;
    public bool canGo = false;
    Vector3 pos = new Vector3(0f, 0f, 0.5f);
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (canGo == true)
        {

            TargetObject.transform.Translate(-pos * Time.deltaTime * speed);
        }
    }

    public void OnPointerDown(PointerEventData data1)
    {
        canGo = true;
    }

    public void OnPointerUp(PointerEventData data1)
    {
        canGo = false;
    }
}
