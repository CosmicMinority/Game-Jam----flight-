using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JankzPickUp : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player" && BackOffMyJankz.backOff == 0)
        {
            BackOffMyJankz.backOff += 1;
        }
    }
}
