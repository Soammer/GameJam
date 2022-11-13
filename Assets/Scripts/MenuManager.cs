using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public GameObject backGround;
    public Image imagePlane;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0)&& backGround.transform.position.y>-700)
        {
            GetComponent<Animator>().SetTrigger("IsSkip");
        }


    }

    public void GameStartButton()
    {
        StartCoroutine(MenuFadeCo(Color.clear, Color.black, 3, 3));//��ȫû����
        StartCoroutine(StartCo(3));
    }

    //͵�������뵭������û��
    private IEnumerator MenuFadeCo(Color from, Color to, float time, float sleepTime)
    {
        yield return new WaitForSeconds(sleepTime);
        float speed = 1 / time;
        float percent = 0;
        while (percent < 1)
        {
            percent += Time.deltaTime * speed;
            imagePlane.color = Color.Lerp(from, to, percent);
            yield return null;
        }
    }

    //Ҳû��
    private IEnumerator StartCo(float sleepTime)
    {
        yield return new WaitForSeconds(sleepTime);
        SceneManager.LoadScene("Game");
    }
}
