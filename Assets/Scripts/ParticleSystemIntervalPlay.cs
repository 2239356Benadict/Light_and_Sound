// Tested in unity editor and Oculus Quest
// Copyright (c) 2239356@swanseauniversity. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.
// Dated: 05/12/2020
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParticleSystemIntervalPlay : MonoBehaviour
{
    public ParticleSystem[] celebrationParicles;

    public AudioSource[] confettiBlastAudio;
   


    void Start()
    {
        InvokeRepeating("PlayParticleWithAnInterval", 3f, 60f);
    }


    public void PlayParticleWithAnInterval()
    {
        foreach(ParticleSystem celeb in celebrationParicles)
        {
            celeb.Play();
            
        }
        foreach(AudioSource audi in confettiBlastAudio)
        {
            audi.Play();
        }
    }
}
