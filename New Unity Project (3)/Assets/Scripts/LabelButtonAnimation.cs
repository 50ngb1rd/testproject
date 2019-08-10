using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabelButtonAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    void Update()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void OnButtonClicked()
    {
        bool counter = anim.GetBool("isClicked");
        if (counter == false)
        {
            anim.SetBool("isClicked", true);
        }
    }
    
}
