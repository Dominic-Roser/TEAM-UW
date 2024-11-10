using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class LaserRainToggle : MonoBehaviour
{
    public ParticleSystem lasers;
    private bool isPlaying = false;


    // This method will be called on Select Entered
    public void OnSelectEntered(SelectEnterEventArgs args)
    {
        // Toggle play/pause based on the current state
        if (isPlaying)
        {
            lasers.Stop();
            isPlaying = false;
        }
        else
        {
            lasers.Play();
            isPlaying = true;
        }
    }
}
