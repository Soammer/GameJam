using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    public GameObject[] Scenes;//场景
    public Player GamePlayer;
    private UIManager UIManager;
    [SerializeField]
    private float time = 3f;//复活玩家等待时间
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
    void Start()
    {
        Instantiate(Scenes[0]);//载入第一个场景

    }
    public void Respawn()
    {
        StartCoroutine("RespawnPlayer");//复活玩家
    }

    public IEnumerator RespawnPlayer()
    {
        GamePlayer.gameObject.SetActive(false);//玩家消失
        yield return new WaitForSeconds(time);//等待时间
        GamePlayer.transform.position = GamePlayer.RespawnPosition;//设置重生点，Player里面还没写
        GamePlayer.gameObject.SetActive(true);//玩家复活
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ReactTag"))//可交互物体
        {
            UIManager.ZArrowAppear(collision.gameObject);//Z剪头UI出现在物体上
            if (Input.GetKeyDown(KeyCode.Z))//按Z键交互
            {
                Debug.Log("交互");
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("ReactTag"))
        {
            UIManager.ZArrowDisappear();//Z剪头UI消失
        }
    }
}
