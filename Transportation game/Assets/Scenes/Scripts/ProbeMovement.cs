using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProbeMovement : MonoBehaviour
{
    public int direction;
    private Rigidbody rb;
    public float speed;
    public float minSecs, MaxSecs;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("WayToGo", 1f);
        //direction = Random.Range(1,4);
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void WayToGo()
        
    {
        direction = Random.Range(1, 4);

        float intervals = Random.Range(minSecs, MaxSecs);
 
        if (direction == 1)
        {
            rb.velocity = Vector3.forward * speed;
        }
        else if (direction == 2)
        {
            rb.velocity = Vector3.back * speed;
        }
        else if (direction == 3)
        {
            rb.velocity = Vector3.left * speed;
        }
        else if (direction == 4)
        {
            rb.velocity = Vector3.right * speed;
        }

        Invoke("WayToGo", intervals);
    }
}
