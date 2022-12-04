using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HandController : MonoBehaviour
{
    ActionBasedController handController;

    public HandScript handScript;

    // Start is called before the first frame update
    void Start()
    {
        handController = GetComponent<ActionBasedController>();    
    }

    // Update is called once per frame
    void Update()
    {
        handScript.SetGrip(handController.selectAction.action.ReadValue<float>());
        handScript.SetTrigger(handController.activateAction.action.ReadValue<float>());
        Debug.Log("Hand Controller");
    }
}
