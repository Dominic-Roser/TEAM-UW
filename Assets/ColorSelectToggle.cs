using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ColorSelectToggle : MonoBehaviour
{
    public GameObject targetObject; // Drag and drop "FFT - Array Drums" here
    private FFTObjectArray_v3 fftScript; // Reference to the FFTObjectArray_v3 script
    public Color newEmissionColor; // Color to set when button is pressed

    private bool isPressed = false;

    private void Start()
    {

        fftScript = targetObject.GetComponent<FFTObjectArray_v3>();
    }

    // This method will be called on Select Entered
    public void OnSelectEntered(SelectEnterEventArgs args)
    {
        // Set the emission color to the new color
        fftScript._EmissionCol = newEmissionColor;
    }
}
