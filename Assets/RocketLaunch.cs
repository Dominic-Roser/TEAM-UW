using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class Fog : MonoBehaviour
{
    public ParticleSystem fog;
    private bool isPlaying = false;


    // This method will be called on Select Entered
    public void OnSelectEntered(SelectEnterEventArgs args)
    {
        // Toggle play/pause based on the current state
        if (isPlaying)
        {
            fog.Stop();
            isPlaying = false;
        }
        else
        {
            fog.Play();
            isPlaying = true;
        }
    }
}