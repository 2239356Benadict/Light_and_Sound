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
            //Debug.Log(confettiBlastAudio.Length);
        }
    }
}
