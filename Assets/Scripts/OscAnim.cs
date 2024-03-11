using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OscAnim : MonoBehaviour
{
    public Transform adsr;
    //public Transform lfo1;
    //public Transform lfo2;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, adsr.position.x * .1f, transform.position.z);
    }
}
