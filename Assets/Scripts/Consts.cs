using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consts : MonoBehaviour
{
    public static Consts instance;
    public void Awake()
    {
        instance = this;
    }
    [System.Serializable]
    public struct dialog
    {
        public int pictureId;//图片ID
    }
    
}
