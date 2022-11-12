using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToNextScene : MonoBehaviour
{
    private Collider2D Coll;
    public GameObject[] Scenes;//�任�ؿ�

    // Start is called before the first frame update
    private void Start()
    {
        Coll = GetComponent<Collider2D>();
    }
    private void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            UIManager.destory = true;
            UIManager.change = true;
            UIManager.timeStop = true;//���϶��ǲ����������ֱ��������UI�ݻ٣��ؿ��л��Լ�ʱͣ
            Invoke("Change", UIManager.stopTime);
            Invoke("timeStop", UIManager.stopTime*2);
        }
    }

    private void Change()
    {
        Scenes[0].SetActive(false);
        Instantiate(Scenes[1]);
    }
    private void timeStop()
    {
        UIManager.timeStop = false;
    }

}
