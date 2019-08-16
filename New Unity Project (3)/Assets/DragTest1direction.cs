using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragTest1direction : MonoBehaviour, IDragHandler, IEndDragHandler
{
    public Vector3 worldPos;
    public Camera cam;
    public RaycastResult r1;
    public bool canMove = false;
    public float speed;
    public float maxLimit;
    public GameObject ToChange;
    public Material TargetMaterial;
    public GameObject Activate;
    public GameObject Activate1;
    public GameObject old;
    public GameObject oldMonitor;
    public GameObject flyingMonitor;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (r1.gameObject != null && canMove == true)
        {
            float yPos = worldPos.y;
            Vector3 pos = new Vector3 (0f, -0.3f, 0f);
            if (this.transform.position.y > maxLimit)
            {
                this.transform.position += pos * speed * Time.deltaTime;
            }
            
        }
    }

    public void OnDrag(PointerEventData data1)
    {
        Vector2 pos = data1.position;
        r1 = data1.pointerCurrentRaycast;
        GameObject g1 = r1.gameObject;
        worldPos = cam.ScreenToWorldPoint(new Vector3(pos.x, pos.y, 2.0f));
        canMove = true;

    }

    public void OnEndDrag(PointerEventData data1)
    {
        canMove = false;
       
        Activate.SetActive(true);
        Activate1.SetActive(true);
        old.SetActive(false);
        oldMonitor.SetActive(false);
       
    }

    


}
