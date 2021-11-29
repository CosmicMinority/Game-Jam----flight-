using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OxygenSC : MonoBehaviour
{
    public static OxygenSC instance;
    public int Oxygen = 100;
    public float decreaserate = 0.1f;
    float nextdecrease = 0f;

    public int MaxOx = 100;
    public int MinOx = 0;

    public Slider OXbar;
    public bool missionFailed;

    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Oxygen >= MaxOx)
        {
            Oxygen = MaxOx;
        }


        if (Oxygen <= MinOx)
        {
            Oxygen = MinOx;
            MovementSc.speed = 5;
            MovementSc.thrust = 5;
            Debug.Log("Failed");

        }
        else
        {
            MovementSc.speed = 20;
            MovementSc.thrust = 17;
        }


        if (Time.time > nextdecrease)
        {
            nextdecrease = Time.time + decreaserate;
            Oxygen--;
        }

        OXbar.value = Oxygen;


    }
}
