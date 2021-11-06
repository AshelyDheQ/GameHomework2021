using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Beat : MonoBehaviour
{
    public GameObject monst;
    private string[] jian;
    public GameObject xianshi;
    // Start is called before the first frame update
    void Start()
    {
        
        jian = new string[4];
        jian[0] = "Q";
        jian[1] = "W";
        jian[2] = "E";
        jian[3] = "S";
    }

    // Update is called once per frame
    void Update()
    {
        xianshi.GetComponent<Text>().text = "¼¼ÄÜ¼ü£º" + jian[Jump.a];
        if (Input.GetButton(jian[Jump.a]))
        {
            monst.SetActive(false);
        }
    }
}
