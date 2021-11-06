using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody2D p1Rigidbody;
    public float speed;//左右速度
    // Start is called before the first frame updates
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 Move = p1Rigidbody.velocity;
        Move.x = 0;
        if (Input.GetKey(KeyCode.A))//左移动
        {
            Move.x -= speed;
        }
        if (Input.GetKey(KeyCode.D))//右移动
        {
            Move.x += speed;
        }
       
        p1Rigidbody.velocity = Move;
    }
}
