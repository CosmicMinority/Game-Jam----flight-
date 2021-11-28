using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackOffMyJankz : MonoBehaviour
{
    public static int backOff = 1;
    public int numberOfIcons;

    public Image[] Icon;
    public Sprite greenIcon;
    public Sprite redIcon;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (backOff > numberOfIcons)
        {
            backOff = numberOfIcons;
        }
        for (int i = 0; i < Icon.Length; i++)
        {
            {
                if (i < backOff)
                {
                    Icon[i].sprite = greenIcon;
                }
                else
                {
                    Icon[i].sprite = redIcon;
                }
            }
            if (i < numberOfIcons)
            {
                Icon[i].enabled = true;
            }
            else
            {
                Icon[i].enabled = false;
            }
        }

    }
}

