using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    private bool followerX;//x�����ӽ��ƶ�
    private bool followerY;//y�����ӽ��ƶ�

    public Transform playerPos;//���λ��
    public float parameter = 0.1f;

    public static cameraFollow instance;
    public void Awake()
    {
        instance = this;
    }

    private void LateUpdate()
    {
        if(playerPos != null)
        {
            if(transform.position != playerPos.position)
            {
                if (followerX)
                {
                    Vector3 targetPos = new Vector3(playerPos.position.x, 1, 1);
                    transform.position = Vector3.Lerp(transform.position,targetPos,parameter);
                }else if (followerY)
                {
                    Vector3 targetPos = new Vector3(1, playerPos.position.y, 1);
                    transform.position = Vector3.Lerp(transform.position, targetPos, parameter);
                }
            }
        }
    }
    
}
