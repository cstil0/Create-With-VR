using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using System.Globalization;

public class setTimeSecond : MonoBehaviour
{
    static DateTime time;
    float degrees;

    // Start is called before the first frame update
    void Start()
    {
        float degrees = 360 / 60 * (float)time.Second;
        time = DateTime.Now;
        //transform.Rotate(0.0f, 360 / 60 * (float)time.Second, 0.0f);
        transform.Rotate(0.0f, degrees, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        float curr_degrees = 360 / 60 * (float)time.Second;
        time = DateTime.Now;
        //transform.Rotate(0.0f, 360 / 60 * (float)time.Second, 0.0f);
        transform.Rotate(0.0f, Math.Abs(curr_degrees - degrees), 0.0f);
        degrees = curr_degrees;
    }
}
