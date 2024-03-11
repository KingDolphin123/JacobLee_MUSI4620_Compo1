using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallDotMove : MonoBehaviour
{
    // Start is called before the first frame update
    Material mat;
    public Transform oscObj;
    private float accum;

    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        float pitch = (oscObj.position.x +5)* .05f;
        accum += pitch  * Time.deltaTime;
        Debug.Log((float)Math.Cos(pitch)*.5f);
        mat.SetFloat("_sizeOfSmallDot", (float)pitch*.3f);
    }
}