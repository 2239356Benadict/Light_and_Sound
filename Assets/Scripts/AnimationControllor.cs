using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControllor : MonoBehaviour
{
    public string[] animationNames;
    public Animator characterAnimator;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("AnimationChange", 10, 30);
    }


    public void AnimationChange(float waitBefore)
    {
 
        int i = Random.Range(0, animationNames.Length);           
        string animation = animationNames[i];

        characterAnimator.Play(animation);

    }
}
