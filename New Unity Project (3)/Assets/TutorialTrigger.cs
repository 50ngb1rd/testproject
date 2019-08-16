using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TutorialTrigger : MonoBehaviour
{

    public Canvas old;
    public Canvas neww;
    public GameObject outline;
    public TextMeshProUGUI TextToChange;
    public bool triggered = false;
    string text1 = "Now we will move it to the work area";
    public Material mMaterial;
    public GameObject port;
    public GameObject mainData;



    // Update is called once per frame
    void Update()
    {
        if (triggered == true)
        {
            old.gameObject.SetActive(false);
            neww.gameObject.SetActive(true);
            outline.SetActive(false);
            port.SetActive(true);
            mainData.SetActive(true);
            
        }

    }

    public void OnTriggerEnter(Collider other)
    {
        GameObject g1 = other.gameObject; ;
        
            triggered = true;
        Renderer r1 = g1.GetComponent<MeshRenderer>();
        r1.material.color = mMaterial.color;


    }
}
