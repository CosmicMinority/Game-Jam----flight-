using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformLandR : MonoBehaviour
{
    //public int direction;
    private Rigidbody rb;
    public float speed;
    public float minSecs, MaxSecs;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("WayToGo", 0f);
        //direction = Random.Range(1,4);
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void WayToGo()

    {

        float intervals = Random.Range(minSecs, MaxSecs);

        {
            rb.velocity = Vector3.right * speed;
        }

        Invoke("WayToGo1", intervals);
    }
    void WayToGo1()

    {

        float intervals = Random.Range(minSecs, MaxSecs);

        {
            rb.velocity = Vector3.left * speed;
        }

        Invoke("WayToGo", intervals);
    }
}
