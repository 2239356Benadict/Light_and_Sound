using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarTargetPoints : MonoBehaviour
{
    public GameObject[] targetPoints;
    public Animator animator;

    private void Start()
    {
        InvokeRepeating("AvatarWalking", 1f, 20f);
    }
    void Update()
    {
        
    }

    public void AvatarWalking()
    {
        GameObject currentTarget = targetPoints[Random.Range(0, 7)];
        Debug.Log(currentTarget.name);
        this.gameObject.transform.LookAt(currentTarget.transform.position);
        
        animator.Play("Walking");
    }
}
