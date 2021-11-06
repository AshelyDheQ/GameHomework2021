using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMoveController : MonoBehaviour
{
    //金币移动的的目标
    GameObject target;
    //金币移动的速度
    public float speed;
    //金币是否可以移动
    public bool isCanMove = false;
    // Start is called before the first frame update
    void Start()
    {
        //获取玩家
        target = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (isCanMove==true)
        {
            //金币向玩家移动的速度
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, Time.deltaTime * speed);
        }
    }
}
