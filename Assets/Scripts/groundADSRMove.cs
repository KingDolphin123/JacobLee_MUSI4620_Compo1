using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundADSRMove : MonoBehaviour
{
    // Start is called before the first frame update
    Material mat;
    public Transform oscObj;

    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        float pitch = oscObj.position.x* .5f;
        mat.SetFloat("_size", pitch);
    }
}