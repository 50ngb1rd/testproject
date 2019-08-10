using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeText : MonoBehaviour
{
    public TextMeshProUGUI textMesh;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
  
    void Update()
    {
        textMesh.GetComponent<TextMeshProUGUI>();
    }
    public void onButtonClicked()
    {
        textMesh.GetComponent<TextMeshProUGUI>();
        textMesh.SetText("Your goal is to create a data packet!");
        string textt = textMesh.text;
        if (textt == "Your goal is to create a data packet!")
        {
            textMesh.SetText("This works for a second time!");
        }
        else
        {
            textMesh.SetText("Wrong!");
        }
    }
}
