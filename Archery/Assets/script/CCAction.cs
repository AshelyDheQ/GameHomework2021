using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCAction : MonoBehaviour
{
    private float time = 1;
    float radian = 0;
    float radius = 0.01f;
    Vector3 initPosition;
    public GameObject Winds1;

    public void Move()
    {
        Move(Winds1.GetComponent<WindController>().GetDirection(), Winds1.GetComponent<WindController>().GetStrength());
    }

    public void Move(Vector3 direction, float strength)
    {
        this.transform.position += direction * strength;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (time > 0)
        {

            if (this.gameObject.tag == "Hit")
            {
                time -= Time.deltaTime;
                // ����ÿ������
                radian += 0.05f;
                // ����
                float dy = Mathf.Cos(radian) * radius;
                transform.position = initPosition + new Vector3(0, dy, 0);
            }
            else
            {
                initPosition = transform.position;
            }
        }
        if (time <= 0)
        {
            this.gameObject.tag = "WaveEnd";
            transform.position = initPosition;
            time = 1;
        }

    }
}
