using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    [SerializeField] private AudioClip soundToPlay; // Assign in Inspector
    private AudioSource audioSource;
    public bool playOnce = true;
    private bool hasPlayed = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        // Ensure the AudioSource is ready but not playing yet
        audioSource.playOnAwake = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("First Person Controller"))
        {
            if (!playOnce || !hasPlayed)
            {
                // Assign the specific clip for this trigger and play it
                audioSource.PlayOneShot(soundToPlay);
                hasPlayed = true;
            }
        }
    }
}