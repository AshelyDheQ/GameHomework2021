using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Daojishi : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMesh>().text = "" + Kid.count_down;//初始化倒计时
        InvokeRepeating("Time_count", 1.0f, 1.0F);//在1秒后每1秒执行一次Time_count方法
    }

    // Update is called once per frame
    void Update()
    {
        if(Kid.end==3)
        {
            GetComponent<TextMesh>().text = "孩子哭声引起了报警，距离警察来还剩" + Kid.count_down;
        }
        if(discover.kai==false)
        {
            GetComponent<TextMesh>().text = "你被发现了，距离警察来还剩" + Kid.count_down;
        }
    }
    void Time_count()//在里面减去1并更新Text文本显示，当数值小于0时就停止CancelInvoke调用。
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
