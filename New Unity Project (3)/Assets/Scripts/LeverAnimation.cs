using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;


    void Update()
    {
        anim = GetComponent<Animator>();
    }

    public void OnLeverClicked()
    {
        bool counter = anim.GetBool("isClicked");
        if (counter == false)
        {
            anim.SetBool("isClicked", true);
        }
        //else if (counter == true)
        //{
            //anim.SetBool("isClicked", false);
        //}






    }
}
    

