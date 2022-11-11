using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    private bool followerX;//x方向视角移动
    private bool followerY;//y方向视角移动
    private float cameraPosX;
    private float cameraPosY;

    public Transform playerPos;//玩家位置
    public float parameter = 0.01f;
    public Vector2 minPosition;
    public Vector2 maxPosition;

    public static cameraFollow instance;
    public void Awake()
    {
        instance = this;
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
        minPosition = minPos;
        maxPosition = maxPos;
    }
}
