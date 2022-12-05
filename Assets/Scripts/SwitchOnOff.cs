// Tested in unity editor and Oculus Quest
// Copyright (c) 2239356@swanseauniversity. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.
// Dated: 05/12/2020
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchOnOff : MonoBehaviour
{
    public GameObject onLightObject;
    public bool grabbedSwitch;
    public bool lightState;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Hand")
        {
            grabbedSwitch = true;
            lightState = true;
            onLightObject.SetActive(true);
            gameObject.transform.Translate(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 0.0111f, gameObject.transform.position.z));
        }
    }
  
}
