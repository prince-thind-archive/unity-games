using UnityEngine;
using System.Collections;

public class Enable : MonoBehaviour
{
    private Light myLight;
    
    
    void Start ()
    {
        myLight = GetComponent<Light>();
    }
    
    
    void Update ()
    {
        if(Input.GetKeyUp(KeyCode.W))
        {
            myLight.enabled = !myLight.enabled;
        }
    }
}