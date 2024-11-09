using UnityEngine;

public class ColorButtons : MonoBehaviour
{
    public Material onmaterial;
    public Material offmaterial;

    public GameObject gameObject;
    public void redPressed() {
        gameObject.GetComponent<Renderer>().material = onmaterial;
        Debug.Log("red pressed");
    }
    public void redReleased() {
        gameObject.GetComponent<Renderer>().material = offmaterial;
        Debug.Log("red released");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
