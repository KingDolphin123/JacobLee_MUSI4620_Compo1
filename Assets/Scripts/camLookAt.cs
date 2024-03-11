using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camLookAt : MonoBehaviour
{
    public Transform target;
    public Transform OscOBJ;
    private float accum;
    [Range(0, 1)]
    [SerializeField] float accumSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        accumSpeed = .5f;
    }

    // Update is called once per frame
    void Update()
    {   
        accum += OscOBJ.position.x  * Time.deltaTime * accumSpeed;
        transform.position = new Vector3(Mathf.Cos(accum), 8, Mathf.Sin(-accum)-15);
        transform.LookAt(target);
    }
}
