using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Content.Interaction;

public class XRPlayPauseAudio : MonoBehaviour
{
    public AudioSource audioSource; // Attach your AudioSource in the Inspector
    public XRSlider slider;
    private bool isPlaying = false;

    public void Update()
    {
        audioSource.volume = slider.value;
    }

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
