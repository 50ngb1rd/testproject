using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Inspect : MonoBehaviour
{
    public TextMeshProUGUI bigMonitor;
    // Start is called before the first frame update
    public void onInspectButtonClicked()
    {
        bigMonitor.GetComponent<TextMeshProUGUI>();
        bigMonitor.SetText("Data packet detected. Contents include an IP address and TCP headers.");
    }
}
