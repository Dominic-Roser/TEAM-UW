using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class FlameStreamToggle : MonoBehaviour
{
    public ParticleSystem flame1;
    public ParticleSystem flame2;
    private bool isPlaying = false;


    // This method will be called on Select Entered
    public void OnSelectEntered(SelectEnterEventArgs args)
    {
        // Toggle play/pause based on the current state
        if (isPlaying)
        {
            flame1.Pause();
            flame1.Pause();
            isPlaying = false;
        }
        else
        {
            flame1.Play();
            flame1.Play();
            isPlaying = true;
        }
    }
}
