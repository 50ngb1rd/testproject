using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InspectText4 : MonoBehaviour
{
    public TextMeshProUGUI ctext1;
    string text1 = "UDP headers detected. Contains target port.";
    string text2 = "No data information detected.";
    public bool textChange1 = false;
    
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (textChange1 == true)
        {
            ctext1 = ctext1.GetComponent<TextMeshProUGUI>();
            ctext1.text = text1;
            ctext1.ForceMeshUpdate(true);
        }
        else if (textChange1 == false)
        {
            ctext1 = ctext1.GetComponent<TextMeshProUGUI>();
            ctext1.text = text2;
            ctext1.ForceMeshUpdate(true);
        }
    }
    public void OnMainData()
    {
        textChange1 = true;
    }

    public void OnMainDataOut()
    {
        textChange1 = false;


    }
}
