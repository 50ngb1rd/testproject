using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LeverPull : MonoBehaviour, IDragHandler, IEndDragHandler
{
    public Camera cam;
    public float speed;
    public GameObject eObject;
    public GameObject fObject;
    public float rotationZ = 0f;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDrag(PointerEventData data1)
    {
        Vector2 pDelta = data1.delta;
        RaycastResult r1 = data1.pointerCurrentRaycast;
         GameObject g1 = r1.gameObject;
        Vector3 worldPos = cam.ScreenToWorldPoint(new Vector3(pDelta.x, pDelta.y, 2.0f));
        //rotationZ += worldPos.y;
        rotationZ += worldPos.x;
        float yPos= Mathf.Clamp(rotationZ, -1, 1);
        //if (g1.transform.eulerAngles.x >= 38)
        //{
            //g1.transform.Rotate(-yPos, 0, 0);
        //}
         //if (g1.transform.eulerAngles.x < 180)
        //{
            g1.transform.Rotate(yPos, 0, 0);
        //}
       
        //g1.transform.Rotate(-worldPos.y, 0,0);
        
      
    }

    public void OnEndDrag(PointerEventData data1)
    {
        RaycastResult r1 = data1.pointerCurrentRaycast;
       GameObject g1 = r1.gameObject;
        var posX = g1.transform.rotation.eulerAngles.x;
        if (posX > 180)
        {
            fObject.SetActive(false);
        }
       
    }
}
