using UnityEngine;

public class DialRotator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject dial;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cube1.transform.Rotate(0.0f, 0.0f, 0.05f, Space.Self);
    }
}
