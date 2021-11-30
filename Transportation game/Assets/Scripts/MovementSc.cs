using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSc : MonoBehaviour
{
    public static float speed = 20;
    public static float thrust = 17;
    public Rigidbody rb;
    public bool canPress = true;
    public float timePlusCooldown = 0;
    public float cooldown = 5;
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject quitButton;
    public GameObject resume;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float Ver = Input.GetAxis("Vertical");
        float Hor = Input.GetAxis("Horizontal");
        Vector3 playermovement = new Vector3(Hor, 0f, Ver) * speed * Time.deltaTime;
        transform.Translate(playermovement, Space.Self);

        if (Input.GetKeyDown(KeyCode.P))
        {
            if(GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        } 
    }

    void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
   
}
