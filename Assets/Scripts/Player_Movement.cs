using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    //movement vars
    public float moveSpeed = 5;
    public Rigidbody2D rb;
    private Vector2 moveDir;

    void Update()
    {
        //take input
        ProcessInput();
    }

    private void FixedUpdate()
    {
        //make calculations
        MovePlayer();
    }

    void ProcessInput()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDir = new Vector2(moveX, moveY).normalized;
    }

    void MovePlayer()
    {
        rb.velocity = new Vector2(moveDir.x * moveSpeed, moveDir.y * moveSpeed);
    }
}
