using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public GameObject pauseUI;//暂停UI
    public GameObject zArrowUI;//Z箭头UI本体
    public GameObject zArrowUIParent;//Z箭头UI生成指向对象
    public GameObject zText;//Z箭头文本
    public GameObject moveText;//移动文本

    //淡入淡出
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
    //单例模式？
    public void PauseUIAppear()//暂停UI出现
    {
        pauseUI.SetActive(true);
    }
    public void PauseUIDisapper()//暂停UI消失
    {
        pauseUI.SetActive(false);
    }
    //Z箭头UI出现，调用方法为
    //ZArrowAppear(Player)；
    public void ZArrowAppear(GameObject ZArrowUIParent)
    {
        zArrowUI.SetActive(true);
        zArrowUI.transform.position = ZArrowUIParent.transform.position + new Vector3(0, 1f, 0);
        //Z箭头调整位置，即移动到父物体上
    }
    public void ZArrowDisappear()//Z箭头UI出现
    {
        zArrowUI.SetActive(false);
    }


    /*淡入淡出，调用方法：
     *例： StartCoroutine(FadeCo(Color.clear, Color.black, 1));    
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
    //用法同上，最后多加个文本对象就可以了……吧
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
