using System.Collections;
using System.Collections.Generic;
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
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void FixedUpdate()
    {
        isGround = Physics2D.OverlapCircle(GroundCheck.position,0.2f,ground);//�ǵü�layer
    }
    // Update is called once per frame
    void Update()
    {
        Move();
        if (Input.GetKeyDown(KeyCode.X) && isGround==true)
        {
            RB.velocity = Vector2.up * jumpforce;//���������Ե����������ʵ�λ��
        }
    }
    public void Move()//�����ƶ�
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= direction * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += direction * speed * Time.deltaTime;
        }
    }
}