using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FFTObjectArray_v3 : MonoBehaviour
{
    public enum Shape
    {
        Line,
        Circle,
    }

    [Header("FFT")]
    public FrequencyBandAnalyser _FFT;
    public FrequencyBandAnalyser.Bands _FreqBands = FrequencyBandAnalyser.Bands.Eight;
    GameObject[] _FFTGameObjects;
    public GameObject _ObjectToSpawn;

    [Header("Object Array")]
    public Shape _Shape = Shape.Line;
    public float _Spacing = 1;
    public Vector3 _ScaleStrength = Vector3.up;
    Vector3 _BaseScale;

    [Header("Emission col")]
    public Color _EmissionCol;
    public float _EmissionStrength = 1;

    private FFTSetMaterialColour[] _setMaterialCols; // Array to store material color components

    void Start()
    {
        _FFTGameObjects = new GameObject[(int)_FreqBands];
        _setMaterialCols = new FFTSetMaterialColour[_FFTGameObjects.Length];
        _BaseScale = _ObjectToSpawn.transform.localScale;

        if (_Shape == Shape.Line)
        {
            // Linear setup
            for (int i = 0; i < _FFTGameObjects.Length; i++)
            {
                GameObject newFFTObject = Instantiate(_ObjectToSpawn);
                newFFTObject.transform.SetParent(transform);
                newFFTObject.transform.localPosition = new Vector3(_Spacing * i, 0, 0);
                _FFTGameObjects[i] = newFFTObject;
            }
        }
        else if (_Shape == Shape.Circle)
        {
            float angleSpacing = (2f * Mathf.PI) / (int)_FreqBands;
            // Circular setup
            for (int i = 0; i < _FFTGameObjects.Length; i++)
            {
                float angle = i * angleSpacing;
                float x = Mathf.Sin(angle) * _Spacing;
                float y = Mathf.Cos(angle) * _Spacing;

                GameObject newFFTObject = Instantiate(_ObjectToSpawn);
                newFFTObject.transform.SetParent(transform);
                newFFTObject.transform.localPosition = new Vector3(x, y, 0);

                // Rotation adjustment
                newFFTObject.transform.LookAt(transform.position);
                newFFTObject.transform.localRotation *= Quaternion.Euler(-90, 0, 0);

                _FFTGameObjects[i] = newFFTObject;
            }
        }

        // Apply and store FFTSetMaterialColour components
        for (int i = 0; i < _FFTGameObjects.Length; i++)
        {
            FFTSetMaterialColour setMaterialCol = _FFTGameObjects[i].AddComponent<FFTSetMaterialColour>();
            setMaterialCol._Col = _EmissionCol;
            setMaterialCol._StrengthScalar = _EmissionStrength;
            setMaterialCol._FFT = _FFT;
            setMaterialCol._FreqBands = _FreqBands;
            setMaterialCol._FrequencyBandIndex = i;

            _setMaterialCols[i] = setMaterialCol; // Store the reference
        }
    }

    private void Update()
    {
        for (int i = 0; i < _FFTGameObjects.Length; i++)
        {
            // Update the scale of each object based on FFT values
            _FFTGameObjects[i].transform.localScale = _BaseScale + (_ScaleStrength * _FFT.GetBandValue(i, _FreqBands));

                _setMaterialCols[i]._Col = _EmissionCol;
        }
    }
}
