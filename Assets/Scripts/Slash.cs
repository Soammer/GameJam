using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slash : MonoBehaviour
{
    private PolygonCollider2D coll2D;
    public float damage;
    public void EndAttack()
    {
        gameObject.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D other)//¹¥»÷
    {
        if(other.gameObject.tag=="enemy")
        {
            other.GetComponent<Enemy>().ChangeHealth(-damage);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
