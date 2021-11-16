using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PhysicalAction : MonoBehaviour
{
    float force = 3;
    public GameObject ScoreText2;
    public void Move() { }


    public void Move(float force)
    {
        this.force = force;
    }

    // Update is called once per frame
    void Update()
    {
        // ���û�����аж���
        if (this.gameObject.transform.position.x < -5)
        {
            ScoreText2.GetComponent<Text>().text = "Null";
            ScoreController.click += 1;
            this.gameObject.tag = "WaveEnd";
        }
    }

    void FixedUpdate()
    {
        // ��������˰ж���
        if (this.gameObject.GetComponent<Rigidbody>() != null)
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(-1, 0, 0) * force);
        }
    }
}
