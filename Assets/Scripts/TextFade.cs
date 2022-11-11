using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFade : MonoBehaviour
{
    public Text text;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            StopCoroutine(FadeTextCo(true, 1, text));
            StartCoroutine(FadeTextCo(false, 1, text));
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            StopCoroutine(FadeTextCo(false, 1, text));
            StartCoroutine(FadeTextCo(true, 1, text));
        }
    }
    public IEnumerator FadeTextCo(bool fade, float time, Text text)
    {
        float speed = 1 / time;
        float alpha = 0;
        if (fade)
        {
            alpha = 1;
            while (alpha >= 0)
            {
                alpha -= Time.deltaTime * speed;
                text.color = new Color(0, 0, 0, alpha);
                yield return new WaitForSeconds(0);
            }
        }
        else
        {
            alpha = 0;
            while (alpha <= 1)
            {
                alpha += Time.deltaTime * speed;
                text.color = new Color(0, 0, 0, alpha);
                yield return new WaitForSeconds(0);
            }
        }
    }
    private void Update()
    {
        if(UIManager.destory)
        {
            Destroy(text);
            Destroy(gameObject);
        }
    }
}
