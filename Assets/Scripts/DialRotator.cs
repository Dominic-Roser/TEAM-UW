using UnityEngine;

public class DialRotator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject dial;
    void Start()
    {
        
    }
    void rotateDialLeft() {
        dial.transform.Rotate(0.0f, 0.05f, 0.0f, Space.Self);
    }
    void rotateDialRight() {
        dial.transform.Rotate(0.0f, 0.05f, 0.0f, Space.Self);
    }
    // Update is called once per frame
    void Update()
    {
        dial.transform.Rotate(0.0f, 0.05f, 0.0f, Space.Self);
    }
}