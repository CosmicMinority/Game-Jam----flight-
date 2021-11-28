using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenPickup : MonoBehaviour
{

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            OxygenSC.instance.Oxygen += 15;
            //Destroy(this.gameObject);
        }
    }
}
