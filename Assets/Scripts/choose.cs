using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choose : MonoBehaviour
{
    public static choose instance;
    public void Awake()
    {
        instance = this;
    }
    public bool isScene3B;
}
