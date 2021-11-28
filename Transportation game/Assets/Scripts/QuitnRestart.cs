using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitnRestart : MonoBehaviour
{
    public KeyCode Dpad;
    public KeyCode Options;
    private void Update()
    {
        if (Input.GetKey(Options))
        {
            SceneManager.LoadScene(1);
        }
        if (Input.GetKey(Dpad))
        {
            Application.Quit();
        }
    }

}
