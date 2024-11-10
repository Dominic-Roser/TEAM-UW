using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class FireFlyToggle : MonoBehaviour
{
    public ParticleSystem flies1;
    private bool isPlaying = false;


    // This method will be called on Select Entered
    public void OnSelectEntered(SelectEnterEventArgs args)
    {
        // Toggle play/pause based on the current state
        if (isPlaying)
        {
            flies1.Stop();
            isPlaying = false;
        }
        else
        {
            flies1.Play();
            isPlaying = true;
        }
    }
}
