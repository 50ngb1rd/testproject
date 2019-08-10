using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class GrabTest : MonoBehaviour
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

    public void OnClick(PointerEventData d1)
    {
        RaycastResult r1 = d1.pointerPressRaycast;
        grabb = r1.gameObject;
        Renderer rend = grabb.GetComponent<MeshRenderer>();
        rend.enabled = false;

    }

}
