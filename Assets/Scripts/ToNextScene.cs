using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToNextScene : MonoBehaviour
{
    private Collider2D Coll;
    public bool isSwitch;//�ж�ͬʱ�䳡����ɫ�Ĺؿ�
    public GameObject[] Scenes;//�任�ؿ�
    public GameObject[] SwitchScenes;//ͬʱ��ؿ���ɫ�ĳ���
    //private bool isChange = true;//�ı䳡��

    // Start is called before the first frame update
    private void Start()
    {
        Coll = GetComponent<Collider2D>();
    }
    private void Update()
    {
        SwitchScene();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            UIManager.destory = true;
            UIManager.change = true;
            Invoke("Change", 3);
        }
    }

    private void Change()
    {
        Scenes[0].SetActive(false);
        Instantiate(Scenes[1]);
    }

    void SwitchScene()
    {
        /*if (isSwitch && Input.GetKeyDown(KeyCode.)//���԰����ı䳡��
        {
            isChange = !isChange;
            if (isChange)
            {
                SwitchScenes[0].SetActive(true);
                SwitchScenes[1].SetActive(false);
            }
            else
            {
                SwitchScenes[0].SetActive(false);
                SwitchScenes[1].SetActive(true);
            }
        }*/
    }
}
