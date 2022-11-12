using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consts : MonoBehaviour
{
    public static Consts instance;
    [TextArea(1,3)]
    public string[] lines;

    [SerializeField] private bool isEntered;
    public void Awake()
    {
        instance = this;
    }
    [System.Serializable]
    public struct dialog
    {
        public int pictureId;//图片ID
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player") isEntered = true;
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Player") isEntered = false;
    }

    private void Update()
    {
        if (isEntered && Input.GetKeyUp(KeyCode.P))
        {
            DialogManager.instance.dailogAddition(lines);
        }
    }
}
