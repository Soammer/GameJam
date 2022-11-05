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
    public GameObject dialogPanel;//对话面板
    public Text dialogText;//对话文本
    public Text nameText;//说话人ID
    [TextArea(1, 3)]
    public string[] dialogLines;//实现逐字滚动时的输入
    [SerializeField] private int currentLines;
    private bool isScrolling = false;//判断文本是否滚动进行

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
            if (Input.GetKeyDown(KeyCode.Space))//输入空格继续对话
            {
                if (isScrolling == false)
                {
                    currentLines++;
                    if (currentLines < dialogLines.Length)
                    {
                        ChekName();
                        StartCoroutine(scrollingTextCo());//实现滚动输出} 
                    }
                }
                if (Input.GetKeyDown(KeyCode.LeftControl))//按下左Ctrl跳过对话
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
