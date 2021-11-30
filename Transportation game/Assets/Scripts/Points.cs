using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour 
{
    OriginalFuelSC originalFuel;
    public Slider OXbar;
    public float gameTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collider collision)
    {
        if(col.gameObject.tag == "Player")
        {
            originalFuelSC.OXbar += 30f; 
        }
    }
}
