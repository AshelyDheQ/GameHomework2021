using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shengchengGOLD : MonoBehaviour
{
    public Rigidbody2D gold;//金币
    public Transform weizhi1;//位置
    public Transform weizhi2;//位置
    public Transform weizhi3;//位置
    public Transform weizhi4;//位置
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D clone;
        clone = (Rigidbody2D)Instantiate(gold, weizhi1.position, weizhi1.rotation);
        clone = (Rigidbody2D)Instantiate(gold, weizhi2.position, weizhi2.rotation);
        clone = (Rigidbody2D)Instantiate(gold, weizhi3.position, weizhi3.rotation);
        clone = (Rigidbody2D)Instantiate(gold, weizhi4.position, weizhi4.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
