using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EventH : MonoBehaviour, IPointerDownHandler

    
{
    public Camera cam;
    public GameObject g1;
    public Vector2 pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerDown(PointerEventData data1)
    {
        RaycastResult r1 = data1.pointerCurrentRaycast;
         g1 = r1.gameObject;
        Vector2 pos = data1.pressPosition;

        Vector3 worldPos = cam.ScreenToWorldPoint(new Vector3(pos.x, pos.y, 2.0f));
        g1.transform.position = worldPos;



    }
}
