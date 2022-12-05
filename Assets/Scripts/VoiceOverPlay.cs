using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceOverPlay : MonoBehaviour
{
    public AudioClip[] converseAudioClips;
    public AudioClip ClapAudioClips;
    public AudioSource avatarAudioSource;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            int randomClip = Random.Range(0, converseAudioClips.Length - 1);
            avatarAudioSource.clip = converseAudioClips[randomClip];
            avatarAudioSource.Play();
            Debug.Log("Playing converse" + other.tag);
        }
    }

}
