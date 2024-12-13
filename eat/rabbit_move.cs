using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rabbit_move : MonoBehaviour
{
    Rigidbody2D rb;
    bool movingRight = true;
    public float speed = 5f;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //print(Screen.width);
        if (transform.position.x > 1)
            movingRight = false;
        if (transform.position.x < -1)
            movingRight = true;
    }

    void FixedUpdate()
    {
        if (movingRight)
            moveRight();
        else
            moveLeft();

    }

    void moveRight()
    {
        rb.velocity = new Vector2(speed, 0);
    }

    void moveLeft()
    {
        rb.velocity = new Vector2(-speed, 0);
    }
}
