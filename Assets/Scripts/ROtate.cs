using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class ROtate : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform newadsr;
    private float accum;
    private float lr = .2f;
    private float lr2 = .15f;
    Material mat;
    bool stop1;

    void Start()
    {
        mat = GetComponent<Renderer>().material;


    }

    // Update is called once per frame
    void Update()
    {
        if (newadsr.position.x>1.2){
            if (!stop1){
                stop1 = true;
                transform.Rotate(UnityEngine.Random.Range(-10.0f, 10.0f)*lr, UnityEngine.Random.Range(-10.0f, 10.0f)*lr, UnityEngine.Random.Range(-10.0f, 10.0f)*lr,Space.Self);
                transform.position = new Vector3(UnityEngine.Random.Range(-6.0f, 6.0f)*lr2, UnityEngine.Random.Range(0f, 6.0f)*lr2+2, UnityEngine.Random.Range(-2.0f, 2.0f)*lr2);
            }
        }
        else if (newadsr.position.x>.8){
            if (stop1){
                stop1 = false;
                transform.Rotate(UnityEngine.Random.Range(-10.0f, 10.0f)*lr, UnityEngine.Random.Range(-10.0f, 10.0f)*lr, UnityEngine.Random.Range(-10.0f, 10.0f)*lr,Space.Self);
                transform.position = new Vector3(UnityEngine.Random.Range(-6.0f, 6.0f)*lr2, UnityEngine.Random.Range(0f, 6.0f)*lr2+2, UnityEngine.Random.Range(-2.0f, 2.0f)*lr2);

            }
        }
        else if (newadsr.position.x>.2){
            if (!stop1){
                stop1 = true;
                transform.Rotate(UnityEngine.Random.Range(-10.0f, 10.0f)*lr, UnityEngine.Random.Range(-10.0f, 10.0f)*lr, UnityEngine.Random.Range(-10.0f, 10.0f)*lr,Space.Self);
                transform.position = new Vector3(UnityEngine.Random.Range(-6.0f, 6.0f)*lr2, UnityEngine.Random.Range(0f, 6.0f)*lr2+2, UnityEngine.Random.Range(-2.0f, 2.0f)*lr2);

            }
        }
        else if (newadsr.position.x>-.01){
            if (stop1){
                stop1 = false;
                transform.Rotate(UnityEngine.Random.Range(-10.0f, 10.0f)*lr, UnityEngine.Random.Range(-10.0f, 10.0f)*lr, UnityEngine.Random.Range(-10.0f, 10.0f)*lr,Space.Self);
                transform.position = new Vector3(UnityEngine.Random.Range(-6.0f, 6.0f)*lr2, UnityEngine.Random.Range(0f, 6.0f)*lr2+2, UnityEngine.Random.Range(-2.0f, 2.0f)*lr2);

            }
        }

        // if(accum>2000){
        //     accum = 0;
        //     lr *= -1;
        // }
        // transform.localScale = new Vector3(adsr.position.x, adsr.position.x, adsr.position.x);
        // transform.position = new Vector3(newadsr.position.x,0,0);
    }
}
