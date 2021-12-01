using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private CharacterController cc;
    public float moveSpeed=15;
    private float horizontalMove, verticalMove;
    private Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal") * moveSpeed;
        verticalMove = Input.GetAxis("Vertical") * moveSpeed;
        dir = transform.forward * verticalMove + transform.right * horizontalMove;
        cc.Move(dir * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftShift))//加速
        {
            moveSpeed = 30;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))//加速
        {
            moveSpeed = 15;
        }
    }
}
