using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraChange : MonoBehaviour
{
    public Camera one;
    public Camera two;
    private void Start()
    {
        one.enabled = true;
        two.enabled = false;
    }
    private void Update()
    {
        if (choose.instance.isScene3B)
        {
            one.enabled = false;
            two.enabled = true;
        }
        else if(!choose.instance.isScene3B)
        {
            one.enabled = true;
            two.enabled = false;
        }
    }
}
