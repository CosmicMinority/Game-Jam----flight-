using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrustLeft : MonoBehaviour
{
    public Rigidbody rb;
    public float thrust;
    public KeyCode L2;
    public GameObject pickupVFX;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(L2))
        {
            rb.AddRelativeForce(0, 0, thrust);
            Instantiate(pickupVFX, transform.position, Quaternion.identity);
            //Boost.AddForceAtPosition(Vector2.up * thrust, thruster01.transform.position);
        }
    }
}
