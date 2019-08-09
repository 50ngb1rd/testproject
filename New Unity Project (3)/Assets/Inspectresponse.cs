using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Inspectresponse : MonoBehaviour
{
    public TextMeshProUGUI text1;
    public GameObject errorText;
    public GameObject correctText;
    public GameObject oldText;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        text1.GetComponent<TextMeshProUGUI>();
       

    }

    public void onInspectButtonClicked()
    {   
        text1.GetComponent<TextMeshProUGUI>();

        errorText.SetActive(false);

        if (text1.text == "Reply received. Click inspect button to see contents.")
        {
            correctText.SetActive(true);
        }
       
        else
        {
            errorText.SetActive(true);
        }
    }
}
