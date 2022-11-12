using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health;
    public float curhealth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public float ChangeHealth(float num)
    {
        curhealth = Mathf.Clamp(curhealth + num, 0, health);
        if (curhealth <= 0)
        {
            Destroy(gameObject);
        }
        return curhealth;
    }
}
