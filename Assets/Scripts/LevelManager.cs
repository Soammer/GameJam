using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    public GameObject[] Scenes;//����
    public Player GamePlayer;
    private UIManager UIManager;
    [SerializeField]
    private float time = 3f;//������ҵȴ�ʱ��
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
        Instantiate(Scenes[0]);//�����һ������

    }
    public void Respawn()
    {
        StartCoroutine("RespawnPlayer");//�������
    }

    public IEnumerator RespawnPlayer()
    {
        GamePlayer.gameObject.SetActive(false);//�����ʧ
        yield return new WaitForSeconds(time);//�ȴ�ʱ��
        GamePlayer.transform.position = GamePlayer.RespawnPosition;//���������㣬Player���滹ûд
        GamePlayer.gameObject.SetActive(true);//��Ҹ���
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ReactTag"))//�ɽ�������
        {
            UIManager.ZArrowAppear(collision.gameObject);//Z��ͷUI������������
            if (Input.GetKeyDown(KeyCode.Z))//��Z������
            {
                Debug.Log("����");
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("ReactTag"))
        {
            UIManager.ZArrowDisappear();//Z��ͷUI��ʧ
        }
    }
}
