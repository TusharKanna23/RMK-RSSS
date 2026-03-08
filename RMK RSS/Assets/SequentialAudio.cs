using System.Collections;
using UnityEngine;

public class SequentialAudio : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip firstClip;
    public AudioClip secondClip;

    void Start()
    {
        // Start the sequence as soon as the game begins
        StartCoroutine(PlayAudioSequence());
    }

    IEnumerator PlayAudioSequence()
    {
        // 1. Play the first audio
        audioSource.clip = firstClip;
        audioSource.Play();

        // 2. Wait for the first clip to finish OR a specific time
        // If you want to wait for the clip to finish + 5 seconds:
        yield return new WaitForSeconds(firstClip.length + 5f);

        // 3. Play the second audio
        audioSource.clip = secondClip;
        audioSource.Play();
    }
}