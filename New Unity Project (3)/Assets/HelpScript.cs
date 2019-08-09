using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HelpScript : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI text;
    public GameObject old;
    public GameObject neww;


    public void Discover()
    {
        text = text.GetComponent<TextMeshProUGUI>();
        if(text.enabled == true)
        {
            old.SetActive(true);
            neww.SetActive(false);
        }
    }
}
