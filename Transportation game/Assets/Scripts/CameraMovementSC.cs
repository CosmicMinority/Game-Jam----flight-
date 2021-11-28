using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementSC : MonoBehaviour
{
    public float CamSpeed;
    public Transform target, player;
    private float mouseX, mouseY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        CamMovement();
    }

    void CamMovement()
    {
        mouseX += Input.GetAxis("Mouse X") * CamSpeed;
        mouseY -= Input.GetAxis("Mouse Y") * CamSpeed;
        mouseY = Mathf.Clamp(mouseY, -90, 30);

        transform.LookAt(target);

        target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
        player.rotation = Quaternion.Euler(0, mouseX, 0);

    }
}
