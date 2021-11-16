using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetTrigger : MonoBehaviour
{
    public GameObject kongScore;
    // ���м�����ĳһ���󴥷�
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
            //�����ٶ�Ϊ0
            arrow.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            arrow.GetComponent<Rigidbody>().isKinematic = true;
            arrow.tag = "Hit";
            // ����������
            int score = this.gameObject.GetComponent<TargetData>().GetScore();
            kongScore.GetComponent<ScoreController>().AddScore(score);
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
