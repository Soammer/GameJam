using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToNextScene : MonoBehaviour
{
    private Collider2D Coll;
    public GameObject[] Scenes;//±ä»»¹Ø¿¨

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
            Invoke("Change", 3);
        }
    }

    private void Change()
    {
        Scenes[0].SetActive(false);
        Instantiate(Scenes[1]);
    }


}
