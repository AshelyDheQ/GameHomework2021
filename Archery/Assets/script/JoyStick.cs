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
        // 只有在射出前能移动
        if(flag)
        {
            float translationY = Input.GetAxis("Vertical") * speedY;
            float translationZ = Input.GetAxis("Horizontal") * speedZ;
            translationY *= Time.deltaTime;
            translationZ *= Time.deltaTime;
            transform.position = transform.position + new Vector3(0, translationY, -translationZ);
            // 限制移动的范围

            if (Input.GetButton("Jump"))
            {
                // 如果空格下，则给箭增加刚体，使其能够进行物理学的运动
                this.gameObject.GetComponent<Rigidbody>().isKinematic = false;
                flag = false;
            }
        }
           
        
    }
   
}
