using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public GameObject pauseUI;//��ͣUI
    public GameObject zArrowUI;//Z��ͷUI����
    public GameObject zArrowUIParent;//Z��ͷUI����ָ�����
    public GameObject zText;//Z��ͷ�ı�
    public GameObject moveText;//�ƶ��ı�

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
    //�÷�ͬ�ϣ�����Ӹ��ı�����Ϳ����ˡ�����
    public IEnumerator FadeTextCo(Text text,float time,float alpha)
    {
        float speed = 1 / time;
        if(alpha==1)
        {
            while(alpha>0)
            {
                alpha -= Time.deltaTime * speed;
                text.color = new Color(0, 0, 0, alpha);
            }
        }
        else if(alpha==0)
        {
            while(alpha<1)
            {
                alpha += Time.deltaTime * speed;
                text.color = new Color(0, 0, 0, alpha);
            }
        }
        yield return null;
    }
}
