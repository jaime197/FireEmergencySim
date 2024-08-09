using UnityEngine;

public class PlaySoundLoop : MonoBehaviour
{
    private AudioSource audioSource;

    public void BeginLoop()
    {
        audioSource = GetComponent<AudioSource>();
        Debug.Log("step 1");

        if (audioSource != null && audioSource.clip != null)
        {
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning("AudioSource or AudioClip is missing!");
        }
    }

    public void StopLoop()
    {
        audioSource = GetComponent<AudioSource>();

        if (audioSource != null && audioSource.clip != null)
        { 
            audioSource.Stop();      
        }
    }
}
