using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XRRigMovement : MonoBehaviour
{
    public Vector3 currentPosition; 
    public Vector3 lastPosition;
    public bool isRigMoving;
    public AudioSource playerAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        isRigMoving = false;
        currentPosition = gameObject.transform.position;
        lastPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        CheckingMovementOfXRRig();
    }

    /// <summary>
    /// Method to check whether the XR_Rig (Player) is moving and updating a bool accordingliy.
    /// </summary>
    void CheckingMovementOfXRRig()
    {
        currentPosition = gameObject.transform.position;
        UpdatingLastPosition();
    }

    /// <summary>
    /// Function to update the last position of the XR Rig.
    /// </summary>
    void UpdatingLastPosition()
    {
        if (currentPosition == lastPosition)
        {
            isRigMoving = false;
            //lastPosition = currentPosition;


        }
        else if (currentPosition != lastPosition)
        {
            isRigMoving = true;
            playerAudioSource.Play();
            Debug.Log("Rig moving: " + isRigMoving);
            lastPosition = transform.position;
        }
    }
}
