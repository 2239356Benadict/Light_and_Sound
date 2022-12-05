// Tested in unity editor and Oculus Quest
// Copyright (c) 2239356@swanseauniversity. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.
// Dated: 05/12/2020
// This script is used to play the audio sequentially. 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeechAudioArray : MonoBehaviour
{
    public AudioClip[] speechAudio;
    public AudioSource speakerAudioSource;

    private void Start()
    {
        StartCoroutine("playAudioSequentially");
    }
    
    /// <summary>
    /// All the audio in the array list will be played in sequence.
    /// </summary>
    /// <returns></returns>
    IEnumerator playAudioSequentially()
    {
        yield return new WaitForSeconds(5);
        yield return null;

        //1.Loop through each AudioClip
        for (int i = 0; i < speechAudio.Length; i++)
        {

            speakerAudioSource.clip = speechAudio[i];

            speakerAudioSource.Play();

            while (speakerAudioSource.isPlaying)
            {
                yield return null;
            }

        }
    }
}
