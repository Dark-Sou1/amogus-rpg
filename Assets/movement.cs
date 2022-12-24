using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class movement : MonoBehaviour
{
    public static float speed = 15f;
    float horizontalInput = 0f;
    float verticalInput = 0f;
    public new Rigidbody2D rigidbody;
    Vector2 move;

    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
        move = new Vector2(horizontalInput, verticalInput).normalized;
        
        changeRotation();
    }
    void FixedUpdate()
    {
        rigidbody.velocity = new Vector2(move.x * speed, move.y * speed);
    }
    void changeRotation()
    {
        var rx = rigidbody.velocity.x;
        var tx = transform.localScale.x;
        var ty = transform.localScale.y;
        var tz = transform.localScale.z;
        if (rx > 0 && tx > 0)
        {
            transform.localScale = new Vector3(-tx, ty, tz);
        }
        else if (rx < 0 && tx < 0)
        {
            transform.localScale = new Vector3(-tx, ty, tz);
        }
    }
}
