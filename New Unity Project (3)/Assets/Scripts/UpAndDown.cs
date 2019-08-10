using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpAndDown : MonoBehaviour
{
    // Start is called before the first frame update

    public Button m_FirstButton;
    // Update is called once per frame
    void Start()
    {
        m_FirstButton.onClick.AddListener(TaskOnClick);
    }
    void Update()
    {
        
        

    }

    public void TaskOnClick()
    {
        Debug.Log("Success");
    }
}
