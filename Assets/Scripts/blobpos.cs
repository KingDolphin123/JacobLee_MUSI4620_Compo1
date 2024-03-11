using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class blobpos : MonoBehaviour
{
    // Start is called before the first frame update
    Material mat;
    public Transform oscObj;
    float size;
    void Start()
    {
        mat = GetComponent<Renderer>().material;
        size = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float pitch = oscObj.position.x;
        
        if(pitch > 0){
            System.Random rnd = new System.Random();
            int nextsize  = rnd.Next(1, 10);
            size = nextsize;
        }
        mat.SetFloat("_rando", (float)size);
    }
}
