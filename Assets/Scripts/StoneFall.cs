using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneFall : MonoBehaviour
{
    private bool isFall=false,isAttack=false;
    private float fallSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.x>=0)
        {
            if(isAttack)
            {

            }
            if(isFall)
            {
                fall();
            }
        }
        else
        {

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            isFall = true;
            isAttack = true;
        }
    }
    private void fall()
    {
        gameObject.transform.position += new Vector3(0, 0, 0);
    }
    private void attack()
    {

    }
}
