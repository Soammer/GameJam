using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    public static DialogManager instance;
    private void Awake()
    {
        instance = this;
    }
    public GameObject dialogPanel;//�Ի����
    public Text dialogText;//�Ի��ı�
    public Text nameText;//˵����ID
    [TextArea(1, 3)]
    public string[] dialogLines;//ʵ�����ֹ���ʱ������
    [SerializeField] private int currentLines;
    private bool isScrolling = false;//�ж��ı��Ƿ��������

    private float time = 0.03f;

    private void Start()
    {
        dialogText.text = dialogLines[currentLines];
        //dialogPanel.SetActive(false);
    }
    private void Update()
    {
        if (dialogPanel.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.Space))//����ո�����Ի�
            {
                if (isScrolling == false)
                {
                    currentLines++;
                    if (currentLines < dialogLines.Length)
                    {
                        ChekName();
                        StartCoroutine(scrollingTextCo());//ʵ�ֹ������} 
                    }
                }
                if (Input.GetKeyDown(KeyCode.LeftControl))//������Ctrl�����Ի�
                {
                    StopCoroutine(scrollingTextCo());
                    dialogPanel.SetActive(false);
                }
            }
        }
    }
    private void ChekName()
    {
        if (dialogLines[currentLines].StartsWith("n-"))
        {
            nameText.text = dialogLines[currentLines].Replace("n-","");
            currentLines++;
        }
    }
    IEnumerator scrollingTextCo()
    {
        isScrolling = true;
        dialogText.text = "";
        dialogPanel.SetActive(true);

        foreach (char letter in dialogLines[currentLines].ToCharArray())
        {
            dialogText.text += letter;
            yield return new WaitForSeconds(time);
        }
        isScrolling = false;
    }
}
