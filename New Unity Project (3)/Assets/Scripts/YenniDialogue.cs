using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class YenniDialogue : MonoBehaviour
{

    public TextMeshProUGUI smallMonitor;
    public TextMeshProUGUI bigMonitor;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {

        smallMonitor.GetComponent<TextMeshProUGUI>();
        bigMonitor.GetComponent<TextMeshProUGUI>();

    }

   

    public void OnHelpButtonClicked()
    {
        
        smallMonitor.GetComponent<TextMeshProUGUI>();
        bigMonitor.GetComponent<TextMeshProUGUI>();
        
        if (bigMonitor.text == "Welcome to Layer 2. Please perform encapsulation to move on to the next stage")
        {
            smallMonitor.GetComponent<TextMeshProUGUI>();
            smallMonitor.SetText("A");
        }

        bigMonitor.GetComponent<TextMeshProUGUI>();

         if (bigMonitor.text == "Unable to complete game as stage is unfinished")
        {
            smallMonitor.GetComponent<TextMeshProUGUI>();
            smallMonitor.SetText("B");
        }
        

    }
}

