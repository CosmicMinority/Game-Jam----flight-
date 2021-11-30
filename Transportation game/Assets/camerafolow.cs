using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafolow : MonoBehaviour
{

    public float forwarspeed;
    public float upspeed;

    // Update is called once per frame
    void Update()
    {
        Vector3 MoveCam = transform.position - transform.forward * forwarspeed + transform.up * upspeed;
        Camera.main.transform.position = MoveCam;


        
    }
}
