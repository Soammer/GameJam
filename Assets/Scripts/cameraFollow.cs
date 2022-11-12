using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public bool followerX;//x�����ӽ��ƶ�����Ҫxʱ��x = true��
    public bool followerY;//y�����ӽ��ƶ�����Ҫyʱ��y = true��{����xʱ�ǵð�yfalse��������yʱͬ��}
    private float cameraPosX;
    private float cameraPosY;
    public GameObject player;
    public Transform playerPos;//���λ�ã�������ϵ����
    public float parameter = 0.01f;
    public Vector2 minPosition;
    public Vector2 maxPosition;

    public static cameraFollow instance;
    public void Awake()
    {
        instance = this;
    }
    public void Update()
    {
        if(UIManager.readPlayer)
        {
            player = GameObject.FindGameObjectWithTag("Player");
            playerPos = player.transform;
            UIManager.readPlayer = false;
        }
    }

    private void LateUpdate()
    {
        cameraPosX = transform.position.x;
        cameraPosY = transform.position.y;
        if (playerPos != null)
        {
            if (transform.position != playerPos.position)
            {
                Vector3 targetPos = playerPos.position;
                if (followerX)
                {
                    targetPos.y = cameraPosY;
                    targetPos.x = Mathf.Clamp(targetPos.x, minPosition.x, maxPosition.x);
                    transform.position = Vector3.Lerp(transform.position, targetPos, parameter);
                }else if (followerY)
                {
                    targetPos.x = cameraPosX;
                    targetPos.y = Mathf.Clamp(targetPos.y, minPosition.y, maxPosition.y);
                    transform.position = Vector3.Lerp(transform.position, targetPos, parameter);
                }
                
            }
        }
    }
    public void cameraLimited(Vector2 minPos,Vector2 maxPos)
    {
        minPosition = minPos;//�ӽ���Сλ�ã��Լ�����
        maxPosition = maxPos;//�ӽ����λ�ã��Լ�����
    }
}
