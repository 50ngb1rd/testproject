using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
public class GrabbTesst : MonoBehaviour
{
    public GameObject grabb;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnSomethingClicked(BaseEventData data1)
    {
        PointerEventData d1 = data1 as PointerEventData;
        RaycastResult r1 = d1.pointerPressRaycast;
        grabb = r1.gameObject;
        Renderer rend = grabb.GetComponent<MeshRenderer>();
        rend.enabled = false;

    }
    // Start is called before the first frame update

    public void OnButtonClicked(BaseEventData data1)
    {
        Renderer rend = grabb.GetComponent<MeshRenderer>();
        rend.enabled = false;
    }
    
}
