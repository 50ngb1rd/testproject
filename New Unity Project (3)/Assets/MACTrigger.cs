using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MACTrigger : MonoBehaviour
{
    public bool triggered = false;
    public GameObject old;
    public GameObject neww;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if(triggered == true)
        {
            old.SetActive(false);
            neww.SetActive(true);
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        GameObject g1 = other.gameObject; ;

        triggered = true;
    }
}
