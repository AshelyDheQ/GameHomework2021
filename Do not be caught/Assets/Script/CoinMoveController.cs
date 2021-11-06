using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMoveController : MonoBehaviour
{
    //����ƶ��ĵ�Ŀ��
    GameObject target;
    //����ƶ����ٶ�
    public float speed;
    //����Ƿ�����ƶ�
    public bool isCanMove = false;
    // Start is called before the first frame update
    void Start()
    {
        //��ȡ���
        target = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (isCanMove==true)
        {
            //���������ƶ����ٶ�
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, Time.deltaTime * speed);
        }
    }
}
