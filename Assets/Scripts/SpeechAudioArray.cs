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
    

    IEnumerator playAudioSequentially()
    {
        yield return new WaitForSeconds(5);
        yield return null;

        //1.Loop through each AudioClip
        for (int i = 0; i < speechAudio.Length; i++)
        {
            //2.Assign current AudioClip to audiosource
            speakerAudioSource.clip = speechAudio[i];

            //3.Play Audio
            speakerAudioSource.Play();

            //4.Wait for it to finish playing
            while (speakerAudioSource.isPlaying)
            {
                yield return null;
            }

            //5. Go back to #2 and play the next audio in the adClips array
        }
    }
}
