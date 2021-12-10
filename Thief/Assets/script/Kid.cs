using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kid : MonoBehaviour
{
    public GameObject tip1;
    public GameObject kid;
    public GameObject kidren;
    public GameObject blood;
    public GameObject daojishi;
    public static int end;
    private bool kai=true;
    public static int count_down = 10;//时间初始值
    // Start is called before the first frame update
    void Start()
    {
        end = 0;
        count_down = 10;
        tip1.SetActive(false);
        blood.SetActive(false);
        daojishi.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Alpha1) && tip1.activeSelf == true)
        {
            end = 1;//劫持
            kid.SetActive(false);
            PlayerMove.moveSpeed = 6;
            kidren.SetActive(false);
        }
        if (Input.GetKey(KeyCode.Alpha2) && tip1.activeSelf == true)
        {
            end = 2;//杀了
            kid.SetActive(false);
            blood.SetActive(true);
            PlayerMove.moveSpeed = 6;
            kidren.SetActive(false);
        }
        if (Input.GetKey(KeyCode.Alpha3) && tip1.activeSelf == true&&kai==true)
        {
            end = 3;//无视
            kai = false;
            daojishi.SetActive(true);
            Daojishi dao = daojishi.AddComponent(typeof(Daojishi)) as Daojishi;
            kid.SetActive(false);
            PlayerMove.moveSpeed = 6;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="kid")
        {
            tip1.SetActive(true);
            PlayerMove.moveSpeed = 0;
        }
    }
}
