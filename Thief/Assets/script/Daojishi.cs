using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Daojishi : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMesh>().text = "" + Kid.count_down;//��ʼ������ʱ
        InvokeRepeating("Time_count", 1.0f, 1.0F);//��1���ÿ1��ִ��һ��Time_count����
    }

    // Update is called once per frame
    void Update()
    {
        if(Kid.end==3)
        {
            GetComponent<TextMesh>().text = "���ӿ��������˱��������뾯������ʣ" + Kid.count_down;
        }
        if(discover.kai==false)
        {
            GetComponent<TextMesh>().text = "�㱻�����ˣ����뾯������ʣ" + Kid.count_down;
        }
    }
    void Time_count()//�������ȥ1������Text�ı���ʾ������ֵС��0ʱ��ֹͣCancelInvoke���á�
    {
        if (Kid.count_down > 0)
        {
            Kid.count_down--;
        }
        else
        {
            CancelInvoke();
            
        }
    }
}
