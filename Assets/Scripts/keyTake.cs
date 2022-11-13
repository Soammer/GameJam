using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyTake : MonoBehaviour
{
    private GameObject key;
    private Collider2D doorCollider;
    private SpriteRenderer keyC;
    private bool doorOpen;
    private void Start()
    {
        doorOpen = false;
        keyC = GetComponent<SpriteRenderer>();
        key = GameObject.FindGameObjectWithTag("key").gameObject;
        doorCollider = GameObject.FindGameObjectWithTag("door").GetComponent<BoxCollider2D>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Destroy(key);
            Destroy(keyC);
            doorOpen = true;
            doorOpenMethod();
        }
    }
    void doorOpenMethod()
    {
        if (doorOpen) doorCollider.isTrigger = true;
        doorOpen = false;
    }
}
