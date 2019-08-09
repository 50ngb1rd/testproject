using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TestYenniTextChange : MonoBehaviour
{
    public TextMeshProUGUI bigMonitor;
    public TextMeshProUGUI smallMonitor;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        bigMonitor.GetComponent<TextMeshProUGUI>();
        smallMonitor.GetComponent<TextMeshProUGUI>();

    }

    public void OnBigButtonClicked()
    {
        //bigMonitor.GetComponent<TextMeshProUGUI>();
        
            bigMonitor.SetText("A");
            bigMonitor.ForceMeshUpdate(true);


    }
    public void OnSmallButtonClicked()
    {
        //bigMonitor.GetComponent<TextMeshProUGUI>();
        //smallMonitor.GetComponent<TextMeshProUGUI>();
        string input = bigMonitor.text;
        switch(input)
        {
            case "hi":
                smallMonitor.SetText("Apple");
                break;
            case "B":
                smallMonitor.SetText("Beta");
                break;
        }
        if(smallMonitor.text == "Apple")
        {
            smallMonitor.text = "Back";
            smallMonitor.ForceMeshUpdate(true);
        }
    }
    
    public void OnBigButton2Clicked()
    {
       //bigMonitor.GetComponent<TextMeshProUGUI>();
        
        
            bigMonitor.SetText("B");
            bigMonitor.ForceMeshUpdate(true);
    
    }
}
