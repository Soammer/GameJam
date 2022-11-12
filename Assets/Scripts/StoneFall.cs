using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneFall : MonoBehaviour
{
    private bool isFall=false;
    private float fallSpeed=1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.y>=-7)
        {
            if(isFall)
            {
                fall();
            }
        }
        else
        {

        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag=="Player")
        {
            //½ÇÉ«ËÀÍö
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("1");
        if(other.tag=="Player")
        {
            isFall = true;
        }
    }
    private void fall()
    {
        gameObject.transform.position -= new Vector3(0, fallSpeed, 0);
    }
}
