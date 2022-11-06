using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public GameObject PauseUI;//��ͣUI
    public GameObject ZArrowUI;//Z��ͷUI����
    public GameObject ZArrowUIParent;//Z��ͷUI����ָ�����


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
    public void ZArrowDisappear()//Z��ͷUI����
    {
        ZArrowUI.SetActive(false);
    }


    /*���뵭�������÷�����
     *���� StartCoroutine(FadeCo(Color.clear, Color.black, 1));    
     */
    public IEnumerator FadeCo(Color from, Color to, float time)
    {
        float speed = 1 / time;
        float percent = 0;
        while (percent < 1)
        {
            percent += Time.deltaTime * speed;
            fadePlane.color = Color.Lerp(from, to, percent);
            yield return null;
        }
    }

}
