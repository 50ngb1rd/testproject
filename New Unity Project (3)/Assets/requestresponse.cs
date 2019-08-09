using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class requestresponse : MonoBehaviour
{
    public TextMeshProUGUI text1;
    public GameObject wrongText;
    string text4 = "ARP Protocol Online";
    string text5 = "Please select communication type";
    string text6 = "Reply received.Inspect for more";
    string text7 = "Here are the details of the reply. Source IP:192.168.172.81. MAC: 00.0a.b7.c9.26.d9";
    string text8 = "Reply discarded. New reply received. Click inspect button to see contents";
    string text9 = "Here are the details of the new reply. Source IP: 192.168.78.10. MAC: 00.0a.b9.c2.77.d6";
    string text10 = "Success. Outputting MAC headers. When output finish click Home to return to production line.";



    // Start is called before the first frame update


    public void onReqButtonClicked()
    {
        text1 = text1.GetComponent<TextMeshProUGUI>();
        text1.ForceMeshUpdate(true);

        if (text1.text == text4)
        {

            text1.text = text5;
            text1.ForceMeshUpdate(true);
           // wrongText.enabled = false;


        }
        else
        {
            //wrongText.enabled = true;

        }
    }
    public void OnUnicastButtonClicked()
    {
        text1 = text1.GetComponent<TextMeshProUGUI>();
        if (text1.text == text5)
        {
            text1.ForceMeshUpdate(true);
            text1.text = text6;
            text1.ForceMeshUpdate(true);
            //wrongText.enabled = false;
        }
        else
        {
            //wrongText.enabled = true;
        }
    }
    public void UnicastButtonError()
    {
        text1.GetComponent<TextMeshProUGUI>();
        //wrongText.SetActive(false);
        text1.ForceMeshUpdate(true);


        if (text1.text != text5)
        {
            //wrongText = wrongText.GetComponent<TextMeshProUGUI>();
            //wrongText.enabled = true;

        }

    }

    public void RequestButtonError()
    {
        text1 = text1.GetComponent<TextMeshProUGUI>();
        text1.ForceMeshUpdate(true);
        if(text1.text != text4)
        {
            //wrongText = wrongText.GetComponent<TextMeshProUGUI>();
            //wrongText.enabled = true;
        }
    }

    public void BroadcastButtonError()
    {
        ///wrongText = wrongText.GetComponent<TextMeshProUGUI>();
        //wrongText.enabled = true;
    }

    public void RequestButtonBehaviour()
    {
        text1 = text1.GetComponent<TextMeshProUGUI>();
        text1.ForceMeshUpdate(true);
        switch (text1.text)
        {
            case "ARP Protocol Online":
                wrongText.SetActive(false);
                text1.text = text5;
                text1.ForceMeshUpdate(true);
                break;

            case "Please select communication type":
                wrongText.SetActive(true);
                break;

            case "Reply received.Inspect for more":
                wrongText.SetActive(true);
                break;

            case "Here are the details of the reply. Source IP:192.168.172.81. MAC: 00.0a.b7.c9.26.d9":
                wrongText.SetActive(true);
                break;

            case "Reply discarded. New reply received. Click inspect button to see contents":
                wrongText.SetActive(true);
                break;

            case "Here are the details of the new reply. Source IP: 192.168.78.10. MAC: 00.0a.b9.c2.77.d6":
                wrongText.SetActive(true);
                break;

            case "Success. Outputting MAC headers. When output finish click Home to return to production line.":
                wrongText.SetActive(true);
                break;


        }
    }

    public void UnicastButtonBehaviour()
    {
        text1 = text1.GetComponent<TextMeshProUGUI>();
        text1.ForceMeshUpdate(true);
        switch (text1.text)
        {
            case "ARP Protocol Online":
                wrongText.SetActive(true);
                break;

            case "Please select communication type":
                wrongText.SetActive(false);
                text1.text = text6;
                text1.ForceMeshUpdate(true);
                break;

            case "Reply received.Inspect for more":
                wrongText.SetActive(true);
                break;

            case "Here are the details of the reply. Source IP:192.168.172.81. MAC: 00.0a.b7.c9.26.d9":
                wrongText.SetActive(true);
                break;

            case "Reply discarded. New reply received. Click inspect button to see contents":
                wrongText.SetActive(true);
                break;

            case "Here are the details of the new reply. Source IP: 192.168.78.10. MAC: 00.0a.b9.c2.77.d6":
                wrongText.SetActive(true);
                break;

            case "Success. Outputting MAC headers. When output finish click Home to return to production line.":
                wrongText.SetActive(true);
                break;


        }
    }

    public void BroadcastButtonBehaviour()
    {
        text1 = text1.GetComponent<TextMeshProUGUI>();
        text1.ForceMeshUpdate(true);
        switch (text1.text)
        {
            case "ARP Protocol Online":
                wrongText.SetActive(true);
                break;

            case "Please select communication type":
                wrongText.SetActive(true);
                break;

            case "Reply received.Inspect for more":
                wrongText.SetActive(true);
                break;

            case "Here are the details of the reply. Source IP:192.168.172.81. MAC: 00.0a.b7.c9.26.d9":
                wrongText.SetActive(true);
                break;

            case "Reply discarded. New reply received. Click inspect button to see contents":
                wrongText.SetActive(true);
                break;

            case "Here are the details of the new reply. Source IP: 192.168.78.10. MAC: 00.0a.b9.c2.77.d6":
                wrongText.SetActive(true);
                break;

            case "Success. Outputting MAC headers. When output finish click Home to return to production line.":
                wrongText.SetActive(true);
                break;


        }
    }

    public void OKButtonBehaviour()
    {
        text1 = text1.GetComponent<TextMeshProUGUI>();
        text1.ForceMeshUpdate(true);
        switch (text1.text)
        {
            case "ARP Protocol Online":
                wrongText.SetActive(true);
                break;

            case "Please select communication type":
                wrongText.SetActive(true);
                break;

            case "Reply received.Inspect for more":
                wrongText.SetActive(true);
                break;

            case "Here are the details of the reply. Source IP:192.168.172.81. MAC: 00.0a.b7.c9.26.d9":
                wrongText.SetActive(true);
                break;

            case "Reply discarded. New reply received. Click inspect button to see contents":
                wrongText.SetActive(true);
                break;

            case "Here are the details of the new reply. Source IP: 192.168.78.10. MAC: 00.0a.b9.c2.77.d6":
                wrongText.SetActive(false);
                text1.text = text10;
                text1.ForceMeshUpdate(true);
                break;

            case "Success. Outputting MAC headers. When output finish click Home to return to production line.":
                wrongText.SetActive(true);
                break;


        }
    }

    public void InspectButtonBehaviour()
    {
        text1 = text1.GetComponent<TextMeshProUGUI>();
        text1.ForceMeshUpdate(true);
        switch (text1.text)
        {
            case "ARP Protocol Online":
                wrongText.SetActive(true);
                break;

            case "Please select communication type":
                wrongText.SetActive(true);
                break;

            case "Reply received.Inspect for more":
                wrongText.SetActive(false);
                text1.text = text7;
                text1.ForceMeshUpdate(true);
                break;

            case "Here are the details of the reply. Source IP:192.168.172.81. MAC: 00.0a.b7.c9.26.d9":
                wrongText.SetActive(true);
                break;

            case "Reply discarded. New reply received. Click inspect button to see contents":
                wrongText.SetActive(false);
                text1.text = text9;
                text1.ForceMeshUpdate(true);
                break;

            case "Here are the details of the new reply. Source IP: 192.168.78.10. MAC: 00.0a.b9.c2.77.d6":
                wrongText.SetActive(true);
                break;

            case "Success. Outputting MAC headers. When output finish click Home to return to production line.":
                wrongText.SetActive(true);
                break;


        }
    }

    public void DiscardButtonBehaviour()
    {
        text1 = text1.GetComponent<TextMeshProUGUI>();
        text1.ForceMeshUpdate(true);
        switch (text1.text)
        {
            case "ARP Protocol Online":
                wrongText.SetActive(true);
                break;

            case "Please select communication type":
                wrongText.SetActive(true);
                break;

            case "Reply received.Inspect for more":
                wrongText.SetActive(true);
                break;

            case "Here are the details of the reply. Source IP:192.168.172.81. MAC: 00.0a.b7.c9.26.d9":
                wrongText.SetActive(false);
                text1.text = text8;
                text1.ForceMeshUpdate(true);
                break;

            case "Reply discarded. New reply received. Click inspect button to see contents":
                wrongText.SetActive(true);
                break;

            case "Here are the details of the new reply. Source IP: 192.168.78.10. MAC: 00.0a.b9.c2.77.d6":
                wrongText.SetActive(true);
                break;

            case "Success. Outputting MAC headers. When output finish click Home to return to production line.":
                wrongText.SetActive(true);
                break;


        }
    }

    public void OnErrorInspect()
    {
        text1.GetComponent<TextMeshProUGUI>();



        if (text1.text == text6)
        {
            //text1.ForceMeshUpdate(true);
           // wrongText.enabled = true;
        }

    }
    public void OnInspectButtonClicked()
    {
        text1.GetComponent<TextMeshProUGUI>();



        if (text1.text == text6)
        {
            text1.ForceMeshUpdate(true);
            //string text = "why";
            text1.text = text7;
            text1.ForceMeshUpdate(true);
            //wrongText.enabled = false;

        }
        else
        {
            //wrongText.enabled = true;
        }
    }
    public void OnDiscardClicked()
    {
        text1.GetComponent<TextMeshProUGUI>();

        text1.ForceMeshUpdate(true);

        if (text1.text == text7)
        {


            text1.text = text8;
            text1.ForceMeshUpdate(true);
            //wrongText.enabled = false;

        }
        else
        {
            //wrongText.enabled = true;
        }
    }
    public void OnErrorDiscard()
    {
        text1.GetComponent<TextMeshProUGUI>();
        //wrongText.SetActive(false);


        if (text1.text == text7)
        {
            text1.ForceMeshUpdate(true);
            //wrongText.enabled = true;
        }

    }
    public void OnSecInspectClicked()
    {
        text1.GetComponent<TextMeshProUGUI>();



        if (text1.text == text8)
        {
            text1.ForceMeshUpdate(true);
            //string text = "why";
            text1.text = text9;
            text1.ForceMeshUpdate(true);
            //wrongText.enabled = false;
        }
        else
        {
            // wrongText.SetActive(true);
        }
    }
    public void OnErrorSecInspect()
    {
        text1.GetComponent<TextMeshProUGUI>();
        //wrongText.SetActive(false);


        if (text1.text == text8)
        {
            text1.ForceMeshUpdate(true);
            //wrongText.enabled = true;
        }

    }


    public void OnOnClicked()
    {
        text1.GetComponent<TextMeshProUGUI>();


        if (text1.text == text9)
        {
            //wrongText.enabled = false;
            text1.ForceMeshUpdate(true);
            //string text = "why";
            text1.text = text10;
            text1.ForceMeshUpdate(true);

        }
        else
        {
            // wrongText.SetActive(true);
        }
    }
    public void OnErrorSecResponse()
    {
        text1.GetComponent<TextMeshProUGUI>();
        //wrongText.SetActive(false);
        text1.ForceMeshUpdate(true);

        if (text1.text == text9)
        {

            //wrongText.enabled = true;

        }



    }
}
