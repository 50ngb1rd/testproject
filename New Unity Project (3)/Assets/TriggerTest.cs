using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TriggerTest : MonoBehaviour
{
    public Material mMaterial;
    // Start is called before the first frame update
    

    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        GameObject g1 = other.gameObject;
        Renderer r1 = g1.GetComponent<MeshRenderer>();
        r1.material.color = mMaterial.color;
    }
}
