using UnityEngine;

public class dialpusher : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject slider;
    public GameObject sliderpanel;
    void Start()
    {
        
    }

    void moveSliderUp() { 
        slider.transform.position += new Vector3(0.0f,0.01f,0.01f);
    }
    void moveSliderDown() { 
        slider.transform.position += new Vector3(0.0f,-0.01f,0.01f);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
