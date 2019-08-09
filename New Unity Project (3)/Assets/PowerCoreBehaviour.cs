using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PowerCoreBehaviour : MonoBehaviour
{
    public TextMeshProUGUI text;
    
    public GameObject oldPowercore;
    public GameObject newPowercore;
    public GameObject oldMonitor;
    public GameObject newMonitor;
    public GameObject newButton;
    public TextMeshProUGUI counterText;
    
    string text1 = "Access granted. Press position to align power core to slot.";
    string text2 = "Please insert power core into the machine.";
    string text3 = "Please pull lever to access power core.";
    string text4 = "Power core successfully inserted.";
    // Start is called before the first frame update


    public void OnDLAnswered()
    {
        text = text.GetComponent<TextMeshProUGUI>();
        counterText = counterText.GetComponent<TextMeshProUGUI>();
        text.ForceMeshUpdate(true);
        if(text.text == text3)
        {
            text.text = text1;
            counterText.text = text1;
            text.ForceMeshUpdate(true);
            
        }
        

    }

    public void OnPositionClicked()
    {
        text.GetComponent<TextMeshProUGUI>();
        
        text.ForceMeshUpdate(true);
        if(text.text == text1)
        {
            
            text.text = text2;
            
            text.ForceMeshUpdate(true);
            

        }

    }

    public void OnPosPowerCore()
    {
        if (counterText.text == text1)
        {

            Renderer rendd = oldPowercore.GetComponent<Renderer>();
            //Renderer newRend = newPowercore.GetComponent<Renderer>();
            rendd.enabled = false;
            //newRend.enabled = true;
        }

    }
    public void OnPosPowerCore2()
    {
        if (counterText.text == text1)
        {

            
            Renderer newRend = newPowercore.GetComponent<Renderer>();
         
            newRend.enabled = true;
        }

    }
    public IEnumerator PowerCoreInsert()
    {
        Vector3 newPosition = new Vector3(-1.1f, 0, 0);
        yield return StartCoroutine(MoveObject.use.Translation(newPowercore.transform, newPosition, 3f, MoveObject.MoveType.Time));
    }

    public IEnumerator PowerCoreInsert2()
    {
        Vector3 newPosition = new Vector3(0.8f, 0, 0);
        yield return StartCoroutine(MoveObject.use.Translation(newPowercore.transform, newPosition, 3f, MoveObject.MoveType.Time));
    }

    public void OnInsertClicked()
    {
        text = text.GetComponent<TextMeshProUGUI>();
        text.ForceMeshUpdate(true);
        if (text.text == text2)
        {
            text.text = text4;
            text.ForceMeshUpdate(true);
           oldMonitor.SetActive(false);
            newMonitor.SetActive(true);
           newButton.SetActive(true);
            
           
           
        }
    }

    

    public void OnCounterUpdate()
    {
        counterText = counterText.GetComponent<TextMeshProUGUI>();
        counterText.ForceMeshUpdate(true);
        if (counterText.text == text1)
        {
            counterText.text = text2;
            counterText.ForceMeshUpdate(true);
        }
   }
    public void OnPowerCoreInsert()
    {
        counterText = counterText.GetComponent<TextMeshProUGUI>();
        counterText.ForceMeshUpdate(true);
        if (counterText.text == text2)
        {
            StartCoroutine(PowerCoreInsert());
        }
    }

    public void OnPowerCoreInsert2()
    {
        counterText = counterText.GetComponent<TextMeshProUGUI>();
        counterText.ForceMeshUpdate(true);
        if (counterText.text == text2)
        {
            StartCoroutine(PowerCoreInsert2());
        }
    }

}


