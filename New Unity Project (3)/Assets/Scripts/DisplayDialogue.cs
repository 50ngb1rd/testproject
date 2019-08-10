using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayDialogue : MonoBehaviour
{
    public TextMeshProUGUI bigMonitor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bigMonitor.GetComponent<TextMeshProUGUI>();
    }
    public void OnButtonClicked()
    {
        bigMonitor.GetComponent<TextMeshProUGUI>();
        string textt = bigMonitor.text;
        if(textt == "Please press the display button to continue.")
        {
            bigMonitor.SetText("Here are your MAC headers! Press complete to send the data to the conveyor belt");
        }
        else
        {
            bigMonitor.SetText("There is nothing to display.");
        }
        
    }
}
