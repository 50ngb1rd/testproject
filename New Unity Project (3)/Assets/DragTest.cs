using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragTest : MonoBehaviour, IDragHandler
{
    public Vector3 worldPos;
    public Camera cam;
    public RaycastResult r1;
    public float offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (r1.gameObject != null)
        {
            this.transform.position = worldPos;
        }
    }

    public void OnDrag(PointerEventData data1)
    {
        Vector2 pos = data1.position;
         r1 = data1.pointerCurrentRaycast;
        GameObject g1 = r1.gameObject;
        worldPos = cam.ScreenToWorldPoint(new Vector3(pos.x, pos.y, offset));
            

        }
}
