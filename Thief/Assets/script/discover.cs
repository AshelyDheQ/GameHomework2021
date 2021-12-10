using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class discover : MonoBehaviour
{
    public GameObject fathers;
   public Transform player;
    float dis;
    public GameObject daojishi;
    public static bool kai = true;
    // Start is called before the first frame update
    void Start()
    {
        daojishi.SetActive(false);
        kai = true;
    }

    // Update is called once per frame
    void Update()
    {
        dis = (transform.position - fathers.transform.position).sqrMagnitude;
        if (dis<=8&&kai==true)
        {
            fathers.GetComponent<father>().enabled = false;
            daojishi.SetActive(true);
            Daojishi dao = daojishi.AddComponent(typeof(Daojishi)) as Daojishi;
            kai = false;
        }
        if(kai==false)
        {
            fathers.transform.LookAt(player);
        }
    }
    
}
