using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class Test3 : MonoBehaviour
{
    GameObject o1;
    public Material yellowMat;




    public void onClick(BaseEventData data)
    {
        OVRPointerEventData pdata = (OVRPointerEventData)data;
        o1 = pdata.pointerCurrentRaycast.gameObject;
        o1.transform.Translate(Vector3.up * Time.deltaTime);
        o1.GetComponent<Renderer>().material = yellowMat;


    }
}

