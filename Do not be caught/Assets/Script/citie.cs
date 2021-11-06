using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class citie : MonoBehaviour
{
    private string[] jian;
    public GameObject xianshi;
    // Start is called before the first frame update
    void Start()
    {
        jian = new string[4];
        jian[0] = "Q";
        jian[1] = "W";
        jian[2] = "E";
        jian[3] = "S";
    }

    // Update is called once per frame
    void Update()
    {
        xianshi.GetComponent<Text>().text = "技能键：" + jian[Jump.a];
        if (Input.GetButton(jian[Jump.a]))
        {
            //检测以玩家为球心半径是5的范围内的所有的带有碰撞器的游戏对象
            Collider2D[] colliders = Physics2D.OverlapCircleAll(this.transform.position, 3);
            foreach (var item in colliders)
            {
                //如果是金币
                if (item.gameObject.tag == "gold")
                {
                    //让金币的开始移动
                    item.GetComponent<CoinMoveController>().isCanMove = true;
                }

            }
        }
        

    }

}
