using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timesDao : MonoBehaviour
{
     int count_down = 70;//ʱ���ʼֵ
    public GameObject door;
    public GameObject opendoor;
    public GameObject doortips;
    public GameObject doortipss;
    // Start is called before the first frame update
    void Start()
   {
        opendoor.GetComponent<BoxCollider>().isTrigger = false;
        GetComponent<Text>().text = "Time: " + count_down;//��ʼ������ʱ
       InvokeRepeating("Time_count", 1.0f, 1.0F);//��1���ÿ1��ִ��һ��Time_count����
   }

   // Update is called once per frame
   void Update()
   {
        if(count_down==0&&Collection.num!=0)//ʧ��
        {
            SceneManager.LoadScene("Scene4");
        }
        if(count_down!=0&&Collection.num==0)//ͨ��
        {
            opendoor.GetComponent<BoxCollider>().isTrigger = true;
            door.SetActive(false);
            Destroy(doortips.gameObject);
            Destroy(doortipss.gameObject);
        }
        if (count_down == 0 && Collection.num == 0)//ͨ��
        {
            door.GetComponent<BoxCollider>().isTrigger = true;
            Destroy(doortips.gameObject);
            Destroy(doortipss.gameObject);
        }
    }
   void Time_count()//�������ȥ1������Text�ı���ʾ������ֵС��0ʱ��ֹͣCancelInvoke���á�
   {
       if (count_down > 0)
       {
           count_down--;
           GetComponent<Text>().text = "Time: " + count_down;
       }
       else
       {
           CancelInvoke();

       }
   } 
}
