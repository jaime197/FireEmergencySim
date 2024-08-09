using UnityEngine;

public class TriggerSound : MonoBehaviour
{
    public GameObject narrator; // Reference to the Narrator object
    private PlayQuickSound3 playQuickSound; // Reference to the PlayQuickSound3 script
    private bool hasTriggered = false; // Flag to prevent multiple triggers

    void Start()
    {
        // Find the Narrator object if not assigned
        if (narrator == null)
        {
            narrator = GameObject.Find("Narrator");
        }

        if (narrator != null)
        {
            playQuickSound = narrator.GetComponent<PlayQuickSound3>();
            if (playQuickSound == null)
            {
                Debug.LogError("PlayQuickSound3 component is not found on Narrator object.");
            }
        }
        else
        {
            Debug.LogError("Narrator object not found.");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the player has entered the trigger zone and if it hasn't been triggered before
        if (!hasTriggered && other.CompareTag("MainCamera"))
        {
            Debug.Log("Yessir");
            hasTriggered = true; // Set flag to true to prevent further triggers
            if (playQuickSound != null)
            {
                playQuickSound.Play();
            }
            else
            {
                Debug.LogWarning("PlayQuickSound3 is missing or not assigned!");
            }
        }
    }
}
