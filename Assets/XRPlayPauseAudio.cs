using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Content.Interaction;

public class XRPlayPauseAudio : MonoBehaviour
{
    //public XRSlider PitchSlider;
    public XRSlider LRSlider;
    public XRSlider VolumeSlider;
    public AudioSource audioSource; // Attach your AudioSource in the Inspectora
    private bool isPlaying = false;
    public int fftSize = 64;
    public int customArraySize = 5;
    public float[] spectrumData;
    public float[] customArray;

    public void Start() {
        spectrumData = new float[fftSize];
        customArray = new float[customArraySize];
    }

    public void updateVolume() {
        audioSource.volume = VolumeSlider.value;
    }
    // public void updatePitch() {
    //     audioSource.pitch = 6.0f*(PitchSlider.value-0.5f);
    // }
    public void updateLR() {
        audioSource.panStereo = 2.0f*(LRSlider.value-0.5f);
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

    public void Update() {
        if (isPlaying) {
            updateVolume();
            // updatePitch();
            updateLR();
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