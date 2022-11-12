using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 direction;
    public float speed;
    public GameObject player;
    public Rigidbody2D RB;
    public float jumpforce;
    public Transform GroundCheck;
    public LayerMask ground;
    private bool isGround;
    public bool canMove;
    SpriteRenderer spriteRenderer; 

    public Vector2 RespawnPosition;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        player = GameObject.FindGameObjectWithTag("Player");
        isGround = true;
        RespawnPosition = player.transform.position;
    }
    private void FixedUpdate()
    {
        //测试时注释掉了
        //isGround = Physics2D.OverlapCircle(GroundCheck.position,0.2f,ground);//记得加layer
    }
    // Update is called once per frame
    void Update()
    {
        if (!UIManager.timeStop)
        {
            Move();
            if (Input.GetKeyDown(KeyCode.X) && isGround == true)
            {
                RB.velocity = Vector2.up * jumpforce;//弹跳力可以调，调到合适的位置
                isGround = false;
            }
        }
    }
    public void Move()//左右移动
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= direction * speed * Time.deltaTime;
            spriteRenderer.flipX = false;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += direction * speed * Time.deltaTime;
            spriteRenderer.flipX = true;
        }

    }
    public void Method(int index, Vector3 pos)
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGround = true;
    }
}
