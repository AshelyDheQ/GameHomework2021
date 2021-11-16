using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Transform son;
    public bool moveToLeft =true;
    private float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        son = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }
    private void move()

    {

        if (son.position.x <= -4f && moveToLeft)

        {

            moveToLeft = false;

        }

        else if (son.position.x >= 0 && !moveToLeft)

            moveToLeft = true;

        son.position += (moveToLeft ? Vector3.left : Vector3.right) * Time.deltaTime * speed;

    }
}
