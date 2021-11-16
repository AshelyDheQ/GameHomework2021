using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider arrow_head)
    {
        //�õ�����
        Transform arrow = arrow_head.gameObject.transform.parent;
        if (arrow == null)
        {
            return;
        }
        if (arrow.tag == "Arrow")
        {
            arrow.GetComponent<CCAction>().Move();
        }
    }
}
