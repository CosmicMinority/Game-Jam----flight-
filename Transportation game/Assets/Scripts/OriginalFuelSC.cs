using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OriginalFuelSC : MonoBehaviour
{
    public Slider OXbar;
    public Text timerText;
    public float gameTime;

    private bool stopTimer;

    public GameObject FueldepletedText;
    public GameObject menuButton;
    public GameObject retryButton;

    // Start is called before the first frame update
    void Start()
    {
        OXbar.maxValue = gameTime;
        OXbar.value = gameTime;
    }

    // Update is called once per frame
    void Update()
    {
        float time = gameTime - Time.time;

        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time - minutes * 60f);

        string textTime = string.Format("{0:0}:{1:00}", minutes, seconds);

        if (time <= 0)
        {
            stopTimer = true;
            FueldepletedText.SetActive(true);
            menuButton.SetActive(true);
            retryButton.SetActive(true);
        }

        if (stopTimer == false)
        {
            timerText.text = textTime;
            OXbar.value = time;
        }
    }

    void FixedUpdate()
    {
        FueldepletedText.SetActive(false);
        menuButton.SetActive(false);
        retryButton.SetActive(false);
    }

}
