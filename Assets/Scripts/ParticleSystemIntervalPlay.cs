using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParticleSystemIntervalPlay : MonoBehaviour
{
    public ParticleSystem[] celebrationParicles;

    public AudioSource[] confettiBlastAudio;
   

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("PlayParticleWithAnInterval", 1f, 18f);
    }

    // Update is called once per frame
    void Update()
    {
        
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
            Debug.Log(confettiBlastAudio.Length);
        }
    }
}
