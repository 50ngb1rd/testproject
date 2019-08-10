using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayData : MonoBehaviour
{
    public Renderer rend;
    public TextMeshProUGUI bigMonitor;


    // Update is called once per frame
    void Update()
    {
        rend.GetComponent<Renderer>();
    }
    public void OnDisplayClicked()
    {
        string textt = bigMonitor.text;
        if (textt == "Click display to your newly created data product.")
        {
            rend.enabled = true;
            bigMonitor.SetText("There is your newly created MAC headers! Please use the send lever to move the data to the conveyor belt.");
        }


    }

    public void OnSendClicked()
    {
        rend.enabled = false;
        bigMonitor.GetComponent<TextMeshProUGUI>();
        if (bigMonitor.text == "There is your newly created MAC headers! Please use the send lever to move the data to the conveyor belt.")
        {
            bigMonitor.SetText("Please label the data");

        }


    }
}
