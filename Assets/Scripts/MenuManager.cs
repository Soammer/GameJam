using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject backGround;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0)&& backGround.transform.position.y>-700)
        {
            GetComponent<Animator>().SetTrigger("IsSkip");
        }


    }




}
