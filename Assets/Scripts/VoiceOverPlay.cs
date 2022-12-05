// This scripts is to play random foley audio while the player collides with the avatars/NPC and this should attach to avatar/NPC.
// Tested in unity editor and Oculus Quest
// Copyright (c) 2239356@swanseauniversity. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.
// Dated: 05/12/2020

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceOverPlay : MonoBehaviour
{
    public AudioClip[] converseAudioClips;
    public AudioClip ClapAudioClips;
    public AudioSource avatarAudioSource;


    /// <summary>
    /// Invoking different forley audio 
    /// </summary>
    /// <param name="other"></param>
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
