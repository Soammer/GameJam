using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public GameObject PauseUI;//暂停UI
    public GameObject ZArrowUI;//Z箭头UI本体
    public GameObject ZArrowUIParent;//Z箭头UI生成指向对象
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            if (instance != this)
            {
                Destroy(gameObject);
            }
        }
        DontDestroyOnLoad(gameObject);
    }
    //单例模式？
    public void PauseUIAppear()//暂停UI出现
    {
        PauseUI.SetActive(true);
    }
    public void PauseUIDisapper()//暂停UI消失
    {
        PauseUI.SetActive(false);
    }
    public void ZArrowAppear(GameObject ZArrowUIParent)//Z箭头UI出现
    {
        ZArrowUI.SetActive(true);
        ZArrowUI.transform.position = ZArrowUIParent.transform.position + new Vector3(0, 1f, 0);
        //Z箭头调整位置，即移动到父物体上
    }
    public void ZArrowDisapper()//Z箭头UI出现
    {
        ZArrowUI.SetActive(false);
    }
}
