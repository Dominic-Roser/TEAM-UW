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
    
    public int fftSize = 64;
    public int customArraySize = 5;
    public float[] spectrumData;
    public float[] customArray;

    public void Start() {
        spectrumData = new float[fftSize];
        customArray = new float[customArraySize];
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

    public void Update() {
        if (isPlaying) {
            //FFT logic here driving the lights and what not
            // Get the spectrum data from the audio source
            audioSource.GetSpectrumData(spectrumData, 0, FFTWindow.Hamming);

            for (int i = 0; i < customArraySize; i++) {
                customArray[i] = spectrumData[(64*i)/customArraySize];
            }

            // spectrumData` now holds the FFT data, you can use it for visualization or analysis
            for (int i = 0; i < customArraySize; i++) {
                // For example, print the magnitude at each frequency bin
                //Debug.Log($"Frequency bin {i}: {spectrumData[i]}");
                Debug.Log($"Frequency bin {i}: {customArray[i]}");
            }
        }
    }
}
