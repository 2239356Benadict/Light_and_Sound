using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AvatarTargetPoints : MonoBehaviour
{
    public GameObject[] avatarToMove; // Avatar gameobjects
    public GameObject[] targetPoints; // Target points for avatar to move
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


    public NavMeshAgent meshAgent;

    private void Start()
    {
        InvokeRepeating("AvatarWalking", startTime, animRepeatTime);
        meshAgent = GetComponent<NavMeshAgent>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            int randomClip = Random.Range(0, converseAudioClips.Length-1);
            avatarAudioSource.clip = converseAudioClips[randomClip];
            avatarAudioSource.Play();
            Debug.Log("Playing converse" + other.tag);
        }
       
    }
    void Update()
    {
        if (moveToTarget)
        {
            AvatarWalking();
        }
    }

    #region Avatar Methods
    /// <summary>
    /// Method to move the avatar to the target points
    /// </summary>
    public void AvatarWalking()
    {
        GameObject currentTarget = targetPoints[Random.Range(0, 7)];
        Debug.Log(currentTarget.name);
        meshAgent.destination = currentTarget.transform.position;
        if (gameObject.transform.position != currentTarget.transform.position)
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
            animator.Play("Waving");
            reachedTarget = true;
        }
    }
    #endregion

}
