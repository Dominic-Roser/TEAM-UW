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
            flame1.Stop();
            flame2.Stop();
            isPlaying = false;
        }
        else
        {
            flame1.Play();
            flame2.Play();
            isPlaying = true;
        }
    }
}
