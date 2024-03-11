using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class setColorLeaves : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform oscObj;
    Material mat;
    bool ison;
    void Start()
    {
       // Create a new cube primitive to set the color on
       

       // Get the Renderer component from the new cube
       mat = GetComponent<Renderer>().material;
       ison = true;
    }
    void Update()
    {
        
        if(oscObj.position.x > 1){
            if (ison == false){
                ison = true;
                mat.SetColor("_Color", Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f));
            }
        }
        else{
            ison = false;
        }
    }
       // Call SetColor using the shader property name "_Color" and setting the color to red
       
}
