using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerattack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!UIManager.timeStop)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                Attack();
            }
        }

    }
    public void Attack()
    {
        transform.GetChild(0).gameObject.SetActive(true);
    }
}
