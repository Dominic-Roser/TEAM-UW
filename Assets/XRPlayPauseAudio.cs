using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRPlayPauseAudio : MonoBehaviour
{
    public AudioSource audioSource; // Attach your AudioSource in the Inspector
    private bool isPlaying = false;


    // This method will be called on Select Entered
    public void OnSelectEntered(SelectEnterEventArgs args)
    {
        // Toggle play/pause based on the current state
        if (isPlaying)
        {
            audioSource.Pause();
            isPlaying = false;
        }
        else
        {
            audioSource.Play();
            isPlaying = true;
        }
    }
}
