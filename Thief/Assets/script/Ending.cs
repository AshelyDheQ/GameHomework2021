using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ending : MonoBehaviour
{
    public GameObject end1;//���
    public GameObject end2;//�ɹ�����
    public GameObject end3;//��ץ
    public GameObject end4;//������ �������ڣ����ˡ���û�õ��������
    public GameObject end5;//������ �������ڣ����ˡ��õ������ɹ�
    public GameObject end6;//�����ڣ����ˡ��õ������ɹ�,�������ӳ���
    // Start is called before the first frame update
    void Start()
    {
        end1.SetActive(false);
        end2.SetActive(false);
        end3.SetActive(false);
        end4.SetActive(false);
        end5.SetActive(false);
        end6.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if(paint.paintNum>0&& Kid.count_down >0)
        {
            end1.SetActive(true);
        }
        if(paint.paintNum <= 0 && Kid.count_down > 0)
        {
            end2.SetActive(true);
        }
        if(Kid.count_down ==0)
        {
            end3.SetActive(true);
        }
        if (Kid.count_down == 0&&Kid.end==1&& paint.paintNum > 0)
        {
            end4.SetActive(true);
        }
        if (Kid.count_down == 0 && Kid.end == 1 && paint.paintNum <= 0)
        {
            end5.SetActive(true);
        }
        if (Kid.count_down >0 && Kid.end == 1 && paint.paintNum <= 0)
        {
            end6.SetActive(true);
        }
    }
}
