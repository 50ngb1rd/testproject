using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InspectText : MonoBehaviour
{
    public TextMeshProUGUI ctext1;
    string text1 = "Main data. Contents: HTML Get";
    string text2 = "No data information detected.";
    public bool textChange = false;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        ctext1.ForceMeshUpdate(true);
        if (textChange == true)
        {
            ctext1 = ctext1.GetComponent<TextMeshProUGUI>();
            ctext1.text = text1;
            ctext1.ForceMeshUpdate(true);
            
        }
        else if (textChange == false)
        {
            ctext1.text = text2;
            ctext1.ForceMeshUpdate(true);

        }

    }
    public void OnMainData()
    {
        textChange = true;
    }

    public void OnMainDataOut()
    {
        textChange = false;
       


    }
}
