using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jump : MonoBehaviour
{
    public Rigidbody2D p1Rigidbody;
    public float speedJump;//跳跃速度
    public bool isJumping = false;//判断是否跳跃的值
    public static int a;
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
        a = Random.Range(0, 4);
    }

    // Update is called once per frame
    void Update()
    {
        xianshi.GetComponent<Text>().text = "技能键：" + jian[a];
        Vector2 Move = p1Rigidbody.velocity;
        Move.x = 0;
        if (Input.GetButton(jian[a]) && isJumping == false)//跳跃
        {
            Move.y += speedJump;
            isJumping = true;
        }
        p1Rigidbody.velocity = Move;
    }
   public void OnCollisionEnter2D(Collision2D coll)//开始碰撞
    {
        if (coll.gameObject.tag == "platform")
        {
            isJumping = false;
        }
    }
}
