using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene4Dialog : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DialogManager.instance.dailogAddition(Consts.instance.lines);
        UIManager.timeStop = true;
    }
}
