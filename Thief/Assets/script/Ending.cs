using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ending : MonoBehaviour
{
    public GameObject end1;//灭口
    public GameObject end2;//成功逃跑
    public GameObject end3;//被抓
    public GameObject end4;//警察来 但人质在，跑了。但没拿到画，灭口
    public GameObject end5;//警察来 但人质在，跑了。拿到画，成功
    public GameObject end6;//人质在，跑了。拿到画，成功,培养孩子长大
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
