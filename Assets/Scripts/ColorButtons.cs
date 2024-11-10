using UnityEngine;

public class ColorButtons : MonoBehaviour
{
    public Material onmaterial;
    public Material offmaterial;
     

    public GameObject gameObject;
    public GameObject redbutton;
    public GameObject bluebutton;
    public GameObject greenbutton;
    public GameObject yellowbutton;
    public GameObject tealbutton;
    public GameObject pinkbutton;

    public void redPressed() {
        redbutton.GetComponent<Renderer>().material = onmaterial;
        Debug.Log("red pressed");
    }
    public void redReleased() {
        redbutton.GetComponent<Renderer>().material = offmaterial;
        Debug.Log("red released");
    }

    public void greenPressed() {
        greenbutton.GetComponent<Renderer>().material = onmaterial;
        Debug.Log("red pressed");
    }
    public void greenReleased() {
        greenbutton.GetComponent<Renderer>().material = offmaterial;
        Debug.Log("red released");
    }
    public void yellowPressed() {
        yellowbutton.GetComponent<Renderer>().material = onmaterial;
        Debug.Log("red pressed");
    }
    public void yellowReleased() {
        yellowbutton.GetComponent<Renderer>().material = offmaterial;
        Debug.Log("red released");
    }
    public void bluePressed() {
        bluebutton.GetComponent<Renderer>().material = onmaterial;
        Debug.Log("red pressed");
    }
    public void blueReleased() {
        bluebutton.GetComponent<Renderer>().material = offmaterial;
        Debug.Log("red released");
    }
    public void pinkPressed() {
        pinkbutton.GetComponent<Renderer>().material = onmaterial;
        Debug.Log("red pressed");
    }
    public void pinkReleased() {
        pinkbutton.GetComponent<Renderer>().material = offmaterial;
        Debug.Log("red released");
    }
    public void tealPressed() {
        tealbutton.GetComponent<Renderer>().material = onmaterial;
        Debug.Log("red pressed");
    }
    public void tealReleased() {
        tealbutton.GetComponent<Renderer>().material = offmaterial;
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
