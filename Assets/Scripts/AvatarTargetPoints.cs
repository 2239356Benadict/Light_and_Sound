// Tested in unity editor and Oculus Quest
// Copyright (c) 2239356@swanseauniversity. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.
// Dated: 05/12/2020

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AvatarTargetPoints : MonoBehaviour
{
    public GameObject seatPosition;     // Avatar seat position
    public GameObject[] targetPoints;   // Target points for avatar to move
    public Animator animator;
    public bool moveToTarget;
    public bool reachedTarget;
    public float moveToTargetSpeed;

    public float startTime;
    public float animRepeatTime;

    public AudioClip[] avatarAudioClips;
    public AudioClip[] converseAudioClips;
    public AudioSource avatarAudioSource;
    public AudioSource avatarAudioSourceFoot;

    public GameObject carLookPoint;
    public int tRP;
    public NavMeshAgent meshAgent;

    private void Start()
    {
        meshAgent = GetComponent<NavMeshAgent>();

        InvokeRepeating("AvatarWalking", startTime, animRepeatTime); 

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            int randomClip = Random.Range(0, converseAudioClips.Length - 1);
            avatarAudioSource.clip = converseAudioClips[randomClip];
            avatarAudioSource.Play();
            Debug.Log("Playing converse" + other.tag);
        }
        if (other.gameObject.tag == "SitPoint")
        {
            animator.Play("Idle");
        }
        else if (other.gameObject.tag == "TargetPoint")
        {
            //animator.Play("Stop Walking");
            animator.Play("Idle");
            gameObject.transform.LookAt(carLookPoint.transform);
            reachedTarget = true;
            tRP++;
        }
    }




    #region Avatar Methods
    /// <summary>
    /// Method to move the avatar to the target points
    /// </summary>
    public void AvatarWalking()
    {
        GameObject currentTarget = targetPoints[Random.Range(0, targetPoints.Length)];
        Debug.Log(currentTarget.name);
        meshAgent.destination = currentTarget.transform.position;
        if (gameObject.transform.position != currentTarget.transform.position && tRP < 5)
        {
            gameObject.transform.LookAt(currentTarget.transform);
            meshAgent.speed = moveToTargetSpeed;
            //gameObject.transform.Translate(Vector3.forward * moveToTargetSpeed * Time.deltaTime);
            animator.Play("Walking");
            avatarAudioSourceFoot.clip = avatarAudioClips[0];
            avatarAudioSource.Play();

        }
        else if ((gameObject.transform.position.x - currentTarget.transform.position.x) < 0.8f)
        {
            animator.Play("Idle");
            gameObject.transform.LookAt(carLookPoint.transform);
            reachedTarget = true;
        }

        if (tRP == 3)
        {
            CancelInvoke("AvatarWalking");
            
        }

    }
    private void StandToSit()
    {

            meshAgent.destination = seatPosition.transform.position;
            gameObject.transform.LookAt(seatPosition.transform);
            meshAgent.speed = moveToTargetSpeed;
            //gameObject.transform.Translate(Vector3.forward * moveToTargetSpeed * Time.deltaTime);
            animator.Play("Walking");
            avatarAudioSourceFoot.clip = avatarAudioClips[0];
            avatarAudioSource.Play(); 
        
    }
    #endregion

}
