using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Discardresponse : MonoBehaviour
{
    public TextMeshProUGUI text1;
    public TextMeshProUGUI errortext;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        text1.GetComponent<TextMeshProUGUI>();
        errortext.GetComponent<TextMeshProUGUI>();

    }

    public void onDiscardButtonClicked()
    {   
        text1.GetComponent<TextMeshProUGUI>();
        errortext.GetComponent<TextMeshProUGUI>();
        errortext.enabled = false;

        if (text1.text == "Reply received. Click inspect button to see contents.")
        {
            errortext.SetText("Error: Reply message needs to be inspected.");
            errortext.enabled = true;
        }
        else if (text1.text == "Here are the details of the reply." + System.Environment.NewLine + "Source IP: X" + System.Environment.NewLine + "Source MAC address: X")
        {
            text1.SetText("Reply discarded. New reply received. Click inspect button to see contents.");
        }
        else if (text1.text == "Here are the details of the reply." + System.Environment.NewLine + "Source IP: Y" + System.Environment.NewLine + "Source MAC address: Y")
        {
            text1.SetText("Message should not be discarded.");
        }
        else
        {
            errortext.enabled = true;
        }
    }
}
