using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static bool destory = false, change = false,timeStop=false;//�ݻ�UI
    public static UIManager instance;
    public GameObject pauseUI;//��ͣUI
    public GameObject zArrowUI;//Z��ͷUI����
    public GameObject zArrowUIParent;//Z��ͷUI����ָ�����

    //���뵭��
    public Image fadePlane;


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
        pauseUI.SetActive(true);
    }
    public void PauseUIDisapper()//��ͣUI��ʧ
    {
        pauseUI.SetActive(false);
    }
    //Z��ͷUI���֣����÷���Ϊ
    //ZArrowAppear(Player)��
    public void ZArrowAppear(GameObject ZArrowUIParent)
    {
        zArrowUI.SetActive(true);
        zArrowUI.transform.position = ZArrowUIParent.transform.position + new Vector3(0, 1f, 0);
        //Z��ͷ����λ�ã����ƶ�����������
    }
    public void ZArrowDisappear()//Z��ͷUI����
    {
        zArrowUI.SetActive(false);
    }


    /*���뵭�������÷�����
     *���� StartCoroutine(FadeCo(Color.clear, Color.black, 1,1));    
     */
    public IEnumerator FadeCo(Color from, Color to, float time, float sleepTime)
    {
        yield return new WaitForSeconds(sleepTime);
        float speed = 1 / time;
        float percent = 0;
        while (percent < 1)
        {
            percent += Time.deltaTime * speed;
            fadePlane.color = Color.Lerp(from, to, percent);
            yield return null;
        }
    }

    private void Update()
    {
        if (change)
        {
            StartCoroutine(FadeCo(Color.clear, Color.black, 3, 0));
            StartCoroutine(FadeCo(Color.black, Color.clear, 3, 3));
            change = false;
        }
    }
}
