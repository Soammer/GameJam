using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public GameObject PauseUI;//��ͣUI
    public GameObject ZArrowUI;//Z��ͷUI����
    public GameObject ZArrowUIParent;//Z��ͷUI����ָ�����
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
    //����ģʽ��
    public void PauseUIAppear()//��ͣUI����
    {
        PauseUI.SetActive(true);
    }
    public void PauseUIDisapper()//��ͣUI��ʧ
    {
        PauseUI.SetActive(false);
    }
    public void ZArrowAppear(GameObject ZArrowUIParent)//Z��ͷUI����
    {
        ZArrowUI.SetActive(true);
        ZArrowUI.transform.position = ZArrowUIParent.transform.position + new Vector3(0, 1f, 0);
        //Z��ͷ����λ�ã����ƶ�����������
    }
    public void ZArrowDisapper()//Z��ͷUI����
    {
        ZArrowUI.SetActive(false);
    }
}
