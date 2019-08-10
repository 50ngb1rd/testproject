using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WrongLabel : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI bigMonitor;

    // Update is called once per frame
    void Update()
    {
        bigMonitor.GetComponent<TextMeshProUGUI>();
    }
    
    public void onWrongBUttonCliked()
    {
        string textt = bigMonitor.text;
        if(textt =="Please select a label.")
        {
            bigMonitor.SetText("The wrong label is selected");
        }
        else
        {
            bigMonitor.SetText("Error. Wrong controls inputted");
        }
    }
    public void onRightButtonClicked()
    {
        string textt = bigMonitor.text;
        if(textt == "Please select a label.")
        {
            bigMonitor.SetText("Data successfully labelled as data frame.");
        }
        else
        {
            bigMonitor.SetText("Error. Wrong controls inputted");
        }
    }
}
