using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class RocketLaunch : MonoBehaviour
{
    public ParticleSystem rocketLaunch;


    // This method will be called on Select Entered
    public void OnSelectEntered(SelectEnterEventArgs args)
    {
        // Toggle play/pause based on the current state
        rocketLaunch.Play();
    }
}