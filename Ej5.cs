﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej5 : MonoBehaviour
{
    private float t = 0;
    private float m = 1.33f;
    private float b = 5f;    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float Y = -m * t + b;
        t += Time.deltaTime;
        if (t <= 3)
        {
            this.transform.localScale = new Vector3(Y, this.transform.localScale.y, this.transform.localScale.z);
        }

       
    }
}
