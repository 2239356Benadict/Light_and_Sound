// This script is used to turn on/off the torch while controllor trigger button
//Tested in unity editor and Oculus Quest
// Dated: 05/12/2020

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TorchOnOff : MonoBehaviour
{
    public GameObject onObject;
    public bool grabbedTorch;
    
    public HandScript handScriptTrigger;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Hand")
        {
            grabbedTorch = true;
        }
        else
        {
            grabbedTorch = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Hand")
        {
            grabbedTorch = false;
        }
        
    }

    private void Update()
    {
        TorchOn();
    }
   
   
    public void TorchOn()
    {
        if (handScriptTrigger.triggerButtonPressed == true && grabbedTorch)
        {
            onObject.SetActive(true);
            
            Debug.Log("TorchON");
        }
        else if (!handScriptTrigger.triggerButtonPressed)
        {
            onObject.SetActive(false);

            Debug.Log("TorchOFF");
        }
    }
}
