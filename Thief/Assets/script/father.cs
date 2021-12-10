using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class father : MonoBehaviour
{
    Transform m_transform;
    Transform m_target;//终点位置
    NavMeshAgent m_agent;//寻路组件
    AudioSource ado;
    float m_speed = 2f;//移动速度
    int nume = 1;
    // Start is called before the first frame update
    void Start()
    {
        m_target = this.transform;
        m_target = GameObject.Find("des1").GetComponent<Transform>();
        m_agent = GetComponent<NavMeshAgent>();
        m_agent.speed = m_speed;
        ado = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(nume==1)
        {
            m_agent.SetDestination(m_target.position);
            Invoke("des22", 15);
        }
        if(nume==2)
        {
            m_agent.SetDestination(m_target.position);
            Invoke("des33", 15);
        }
        if (nume == 3)
        {
            m_agent.SetDestination(m_target.position);
            Invoke("des44", 15);
        }
        if (nume == 4)
        {
            m_agent.SetDestination(m_target.position);
            Invoke("des11", 15);
        }
    }
    void des11()
    {
        m_target = GameObject.Find("des1").GetComponent<Transform>();
        nume = 1;
    }
    void des22()
    {
        m_target = GameObject.Find("des2").GetComponent<Transform>();
        nume = 2;
    }
    void des33()
    {
        m_target = GameObject.Find("des3").GetComponent<Transform>();
        nume = 3;
    }
    void des44()
    {
        m_target = GameObject.Find("des4").GetComponent<Transform>();
        nume = 4;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="des")
        {
            ado.volume = 0;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "des")
        {
            ado.volume = 1;
        }
    }
}
