using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetTrigger : MonoBehaviour
{
    public GameObject kongScore;
    // 当有箭射中某一环后触发
    void OnTriggerEnter(Collider arrow_head)
    {
        //得到箭身
        Transform arrow = arrow_head.gameObject.transform.parent;
        if (arrow == null)
        {
            return;
        }
        if (arrow.tag == "Arrow")
        {
            //箭身速度为0
            arrow.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            arrow.GetComponent<Rigidbody>().isKinematic = true;
            arrow.tag = "Hit";
            // 分数控制器
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
