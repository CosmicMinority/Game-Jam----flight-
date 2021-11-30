using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forwardandupspeed : MonoBehaviour
{
    public float speed;
    public float lift;
    public float maxSpeed;

    public Rigidbody rb;

    public Camera cam;


    public float forwarspeed;
    public float upspeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 MoveCam = transform.position - transform.forward * forwarspeed + Vector3.up * upspeed;
        cam.transform.position = MoveCam;
        cam.transform.LookAt(rb.transform.position);

        Quaternion Devicerotation = DeviceRotation.Get();

        transform.rotation = Devicerotation;

        rb.AddForce(transform.forward * speed, ForceMode.Acceleration);
        rb.AddForce(transform.up * lift, ForceMode.Acceleration);

        rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);
        
    }
}
