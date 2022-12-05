// Tested in unity editor and Oculus Quest
// Copyright (c) 2239356@swanseauniversity. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.
// Dated: 05/12/2020

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
