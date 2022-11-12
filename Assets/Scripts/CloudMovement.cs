using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovement : MonoBehaviour
{
    private Rigidbody2D RB;
    public Transform left, right;
    public float Speed;
    private float LeftX, RightX;
    private bool isRight;
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        LeftX = left.position.y;
        RightX = right.position.y;
        Destroy(left.gameObject);
        Destroy(right.gameObject);
    }

    void Update()
    {
        Movement();
    }
    void Movement()
    {

        if (isRight)
        {
            RB.velocity = new Vector2(Speed, RB.velocity.y);
            if (transform.position.x > RightX)
            {
                isRight = false;
            }
        }
        else
        {
            RB.velocity = new Vector2(-Speed, RB.velocity.y);
            if (transform.position.x < LeftX)
            {
                isRight = true;
            }
        }
    }
}
