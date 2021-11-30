using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gyrocontrol : MonoBehaviour
{
    public float number;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Input.acceleration.x *number, 0, Input.acceleration.z* number);
    }
}
