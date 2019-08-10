using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WrongPText : MonoBehaviour
{

    public TextMeshProUGUI bigMonitor;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {

        bigMonitor.GetComponent<TextMeshProUGUI>();

    }

    public void onTCPButtonClicked()
    {

        bigMonitor.GetComponent<TextMeshProUGUI>();
        bigMonitor.SetText("Error. Unable to perform TCP protocol");

    }

    public void onDHCPButtonClicked()
    {

        bigMonitor.GetComponent<TextMeshProUGUI>();
        bigMonitor.SetText("Error. Unable to perform DHCP protocol.");

    }

    public void OnARPButtonClicked()
    {
        bigMonitor.GetComponent<TextMeshProUGUI>();
        bigMonitor.SetText("Loading ARP protocol");
    }
    public void OnSendButtonClicked()
    {
        bigMonitor.GetComponent<TextMeshProUGUI>();
        string textt = bigMonitor.text;
        if (textt == "Please press send to send the data to the conveyor belt")
        {
            bigMonitor.SetText("Data sent successfully");

        }
        else
        {
            bigMonitor.SetText("There is nothing to send at this time.");
        }



    }

    public void OnCompleteButtonClicked()
    {
        bigMonitor.GetComponent<TextMeshProUGUI>();
        string textt = bigMonitor.text;
        if (textt == "Please press complete to finish the game.")
        {
            bigMonitor.SetText("Congratulations!");
        }
        else
        {
            bigMonitor.SetText("Unable to complete game as stage is unfinished");
        }

            
    }
}
