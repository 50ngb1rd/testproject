using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LabelResponseSuccess : MonoBehaviour
{
    public TextMeshProUGUI bigMonitor;
    // Start is called before the first frame update
    public void OnWrongLabelSelected()
    {
        bigMonitor.GetComponent<TextMeshProUGUI>();
        bigMonitor.SetText("Error. Wrong Label");

    }

    public void onRightLabelSelected()
    {
        bigMonitor.GetComponent<TextMeshProUGUI>();
        bigMonitor.SetText("Data labelled successfully. Please use the complete lever to complete encapsulation");
    }
}
