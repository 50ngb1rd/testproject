using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MovingData : MonoBehaviour
{
    // Start is called before the first frame update
    public Renderer rend;
   


    // Update is called once per frame
    void Update()
    {
        rend.GetComponent<Renderer>();
    }
    public void OnSendClicked()
    {
       
            rend.enabled = true;
           


    }
}
