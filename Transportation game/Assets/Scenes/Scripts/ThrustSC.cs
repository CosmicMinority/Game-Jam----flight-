using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrustSC : MonoBehaviour
{
    public Rigidbody rb;
    public float thrustR2;
    public KeyCode R2;
    public GameObject pickupVFX;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(R2))
        {
            rb.AddRelativeForce(0, 0, thrustR2);
            Instantiate(pickupVFX, transform.position, Quaternion.identity);
            //Boost.AddForceAtPosition(Vector2.up * thrust, thruster01.transform.position);
        }
    }
}
