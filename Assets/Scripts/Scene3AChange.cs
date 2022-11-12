using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene3AChange : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            DialogManager.instance.dailogAddition(Consts.instance.lines);
            UIManager.timeStop = true;
        }
    }
}
