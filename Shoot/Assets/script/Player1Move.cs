using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Move : MonoBehaviour
{
    public Rigidbody2D p1Rigidbody;
    public float speed;//�����ٶ�
    public float speedJump;//��Ծ�ٶ�
    private bool isJumping = false;//�ж��Ƿ���Ծ��ֵ
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 Move= p1Rigidbody.velocity;
        Move.x = 0;
        if(Input.GetKey(KeyCode.A))//���ƶ�
        {
            Move.x -= speed;
        }
        if (Input.GetKey(KeyCode.D))//���ƶ�
        {
            Move.x += speed;
        }
        if (Input.GetKey(KeyCode.W)&&isJumping==false)//��Ծ
        {
            Move.y += speedJump;
            isJumping = true;
        }
        p1Rigidbody.velocity = Move;
    }
    void OnCollisionEnter2D(Collision2D coll)//��ʼ��ײ
    {
        if (coll.gameObject.tag == "platform")
        {
            isJumping = false;
        }
    }
}
