using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveH, moveV;
    public float moveSpeed = 2.0f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    private void Update()
    {
        moveH = Input.GetAxisRaw("Horizontal") * moveSpeed;
        moveV = Input.GetAxisRaw("Vertical") * moveSpeed;
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveH, moveV).normalized;
    }
}
