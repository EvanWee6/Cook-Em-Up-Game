using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float move_speed = 5;

    float movementX;
    float movementY;

    Rigidbody2D rb;

    void Start()
    {
        movementX = 0;
        movementY = 0;

    }



    void Update()
    {




        Vector3 moveDir = new Vector3(movementX, movementY).normalized;
        transform.position += moveDir * move_speed * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.W))
        {
            movementY += 1;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            movementY -= 1;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            movementY -= 1;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            movementY += 1;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            movementX += 1;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            movementX -= 1;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            movementX -= 1;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            movementX += 1;
        }

    }
}
