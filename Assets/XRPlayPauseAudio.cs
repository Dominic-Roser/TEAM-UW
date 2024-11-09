using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Content.Interaction;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class XRPlayPauseAudio : MonoBehaviour
{
    public AudioSource audioSource; // Attach your AudioSource in the Inspector
    public XRSlider slider;
    public PausePlayText pausePlay;
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
            //Set text to Pause
        }
        else
        {
            audioSource.Play();
            isPlaying = true;
            //Set text to play
        }
    }
}
