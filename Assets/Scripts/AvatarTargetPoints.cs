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
    public float moveToTargetSpeed;

    public NavMeshAgent meshAgent;

    private void Start()
    {
        //InvokeRepeating("AvatarWalking", 1f, 20f);
        meshAgent = GetComponent<NavMeshAgent>();
       
    }
    void Update()
    {
        if (moveToTarget)
        {
            AvatarWalking();
        }
    }

    /// <summary>
    /// Method to move the avatar to the target points
    /// </summary>
    public void AvatarWalking()
    {
        GameObject currentTarget = targetPoints[Random.Range(0, 7)];
        Debug.Log(currentTarget.name);
        meshAgent.destination = currentTarget.transform.position;
        if(gameObject.transform.position != currentTarget.transform.position)
        {
            gameObject.transform.LookAt(currentTarget.transform);
            meshAgent.speed = moveToTargetSpeed;
            //gameObject.transform.Translate(Vector3.forward * moveToTargetSpeed * Time.deltaTime);
            animator.Play("Walking");

        }
        else if(gameObject.transform.position == currentTarget.transform.position)
        {
            animator.Play("Idle");
        }
    }
}
