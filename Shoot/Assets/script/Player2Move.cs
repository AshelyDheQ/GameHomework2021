using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Move : MonoBehaviour
{
    public Rigidbody2D p2Rigidbody;
    public float speed;//左右速度
    public float speedJump;//跳跃速度
    private bool isJumping = false;//判断是否跳跃的值
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 Move = p2Rigidbody.velocity;
        Move.x = 0;
        if (Input.GetKey(KeyCode.LeftArrow))//左移动
        {
            Move.x -= speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))//右移动
        {
            Move.x += speed;
        }
        if (Input.GetKey(KeyCode.UpArrow) && isJumping == false)//跳跃
        {
            Move.y += speedJump;
            isJumping = true;
        }
        p2Rigidbody.velocity = Move;
    }
    void OnCollisionEnter2D(Collision2D coll)//开始碰撞
    {
        if (coll.gameObject.tag == "platform")
        {
            isJumping = false;
        }
    }
}