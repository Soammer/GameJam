using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ObjectAppear : MonoBehaviour
{
    public GameObject[] TgameObject;
    public GameObject[] FgameObject;
    private Collider2D Coll;
    private void Start()
    {
        Coll= GetComponent<Collider2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag =="Player")
        {
            for(int i = 0; i < TgameObject.Length; i++)
            {
                TgameObject[i].SetActive(true);
            }
            for(int j=0;j<FgameObject.Length;j++)
            {
                FgameObject[j].SetActive(false);
            }

        
        }
    }
}
