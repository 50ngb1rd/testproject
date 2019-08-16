using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UDPtrigger : MonoBehaviour
{
    public GameObject UDPNew;
    
    public bool triggered = false;
    public GameObject neww;
    public GameObject old;
    public GameObject outline;


    // Update is called once per frame
    void Update()
    {
        if(triggered == true)
        {
            UDPNew.SetActive(true);
           
            old.SetActive(false);
            neww.SetActive(true);
            outline.SetActive(false);
        }

    }

    public void OnTriggerEnter(Collider other)
    {
        GameObject g1 = other.gameObject;
        g1.SetActive(false);
        triggered = true;
        

    }
}


