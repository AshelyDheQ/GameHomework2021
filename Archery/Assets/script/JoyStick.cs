using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyStick : MonoBehaviour
{
    public float speedZ = 1.0F;
    public float speedY = 1.0F;
    public static bool flag = true;
    // Update is called once per frame
    void Update()
    {
        // ֻ�������ǰ���ƶ�
        if(flag)
        {
            float translationY = Input.GetAxis("Vertical") * speedY;
            float translationZ = Input.GetAxis("Horizontal") * speedZ;
            translationY *= Time.deltaTime;
            translationZ *= Time.deltaTime;
            transform.position = transform.position + new Vector3(0, translationY, -translationZ);
            // �����ƶ��ķ�Χ

            if (Input.GetButton("Jump"))
            {
                // ����ո��£���������Ӹ��壬ʹ���ܹ���������ѧ���˶�
                this.gameObject.GetComponent<Rigidbody>().isKinematic = false;
                flag = false;
            }
        }
           
        
    }
   
}
