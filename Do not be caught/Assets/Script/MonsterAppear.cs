using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MonsterAppear : MonoBehaviour
{
   
    public GameObject monster;//恶魔
    public GameObject player;
    public float attackrange;
    public float movespeed;
    // Start is called before the first frame update
    void Start()
    {
        monster.SetActive(false);
        InvokeRepeating("MonsterApp", 5.0f, 15.0F);//在5秒后每10秒执行一次Time_count方法
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(player.transform.position, transform.position);
        if (dist > attackrange)
        {
            transform.Translate(Vector3.right * movespeed * Time.deltaTime);
        }


        Vector2 direction = player.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);


    }
    public void MonsterApp()
    {

        monster.SetActive(true);
        monster.transform.position = new Vector3(16, 12, 0);
            //clone.velocity = new Vector2(+speed, 0);//给子弹赋给速度
        
    }
   
}
