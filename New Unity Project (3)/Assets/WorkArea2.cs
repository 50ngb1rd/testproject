using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WorkArea2 : MonoBehaviour
{

    public bool triggered = false;
    public Material mMaterial;
    public Canvas old;
    public Canvas neww;
    public TextMeshProUGUI newText;
    public TextMeshProUGUI oldText;
    public GameObject outline;
    public GameObject newButton;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (triggered == true)
        {
            old.gameObject.SetActive(false);
            neww.gameObject.SetActive(true);
            newText.enabled = true;
            oldText.enabled = false;
            outline.SetActive(true);
            newButton.SetActive(true);
        }

    }
    public void OnTriggerEnter(Collider other)
    {
        GameObject g1 = other.gameObject; ;

        triggered = true;
        g1.SetActive(false);
        Renderer r1 = g1.GetComponent<MeshRenderer>();
        r1.material.color = mMaterial.color;
    }
}
