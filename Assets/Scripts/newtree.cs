using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newtree : MonoBehaviour
{
    public GameObject tree;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(tree==null)
        {
            gameObject.SetActive(true);
        }
    }
}
