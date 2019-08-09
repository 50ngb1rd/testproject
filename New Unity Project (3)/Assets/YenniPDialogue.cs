using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class YenniPDialogue : MonoBehaviour
{
    public TextMeshProUGUI text;
    string oriText = "Welcome to the ARP stage! You will have to use the machine you see in front of you to create MAC headers to add to your data packet";
    string text1 = "You can use the ARP machine through the controls in the panel in front of you.";
    string text2 = "Before we can use the machine, it looks like its out of power.";
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        text.GetComponent<TextMeshProUGUI>();
    }

    public void OnFirstChange()
    {
        text.GetComponent<TextMeshProUGUI>();
        if (text.text == oriText)
        {
            text.text = text1;
            text.ForceMeshUpdate(true);
        }
    }

    public void OnSecondChange()
    {
        text.GetComponent<TextMeshProUGUI>();
        text.ForceMeshUpdate(true);
        if(text.text == text1)
        {
            text.text = text2;
            text.ForceMeshUpdate(true);
        }
    }
}
