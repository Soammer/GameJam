using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToNextScene : MonoBehaviour
{
    private Collider2D Coll;
    public bool isSwitch;//判断同时变场景角色的关卡
    public GameObject[] Scenes;//变换关卡
    public GameObject[] SwitchScenes;//同时变关卡角色的场景
    //private bool isChange = true;//改变场景

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
        /*if (isSwitch && Input.GetKeyDown(KeyCode.)//可以按键改变场景
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
