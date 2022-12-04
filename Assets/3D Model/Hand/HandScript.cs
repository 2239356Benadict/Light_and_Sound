using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandScript : MonoBehaviour
{
    public Animator handAnimator;
    public string animParamenterNameGrip = "Grip";
    public string animParamenterNameTrigger = "Trigger";

    private float gripTarget;
    private float currentGripValue;
    private float triggerTarget;
    private float currentTriggerValue;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AnimateHand();
    }

    private void AnimateHand()
    {
        if(currentGripValue != gripTarget)
        { 
            currentGripValue = Mathf.MoveTowards(currentGripValue, gripTarget, Time.deltaTime * speed);
            handAnimator.SetFloat(animParamenterNameGrip, currentGripValue);
            Debug.Log("Grip");
        }
        if(currentTriggerValue != triggerTarget)
        { 
            currentTriggerValue = Mathf.MoveTowards(currentTriggerValue, triggerTarget, Time.deltaTime * speed);
            handAnimator.SetFloat(animParamenterNameTrigger, currentTriggerValue);
            Debug.Log("Trigger");
        }
    }

    public void SetGrip(float pressvalue)
    {
        gripTarget = pressvalue;
    } 
    
    public void SetTrigger(float pressvalue)
    {
        triggerTarget = pressvalue;
    }
}
