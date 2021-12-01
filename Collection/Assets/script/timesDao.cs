using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timesDao : MonoBehaviour
{
     int count_down = 70;//时间初始值
    public GameObject door;
    public GameObject opendoor;
    public GameObject doortips;
    public GameObject doortipss;
    // Start is called before the first frame update
    void Start()
   {
        opendoor.GetComponent<BoxCollider>().isTrigger = false;
        GetComponent<Text>().text = "Time: " + count_down;//初始化倒计时
       InvokeRepeating("Time_count", 1.0f, 1.0F);//在1秒后每1秒执行一次Time_count方法
   }

   // Update is called once per frame
   void Update()
   {
        if(count_down==0&&Collection.num!=0)//失败
        {
            SceneManager.LoadScene("Scene4");
        }
        if(count_down!=0&&Collection.num==0)//通关
        {
            opendoor.GetComponent<BoxCollider>().isTrigger = true;
            door.SetActive(false);
            Destroy(doortips.gameObject);
            Destroy(doortipss.gameObject);
        }
        if (count_down == 0 && Collection.num == 0)//通关
        {
            door.GetComponent<BoxCollider>().isTrigger = true;
            Destroy(doortips.gameObject);
            Destroy(doortipss.gameObject);
        }
    }
   void Time_count()//在里面减去1并更新Text文本显示，当数值小于0时就停止CancelInvoke调用。
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
