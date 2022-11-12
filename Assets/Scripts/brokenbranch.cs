using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class brokenbranch : MonoBehaviour
{
    public GameObject branch;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (branch == null)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}
