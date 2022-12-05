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
