using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music2 : MonoBehaviour
{
    public GameObject obje;
 GameObject obj = null;
    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.FindGameObjectWithTag("Sound");
        if (obj == null)
        {
            obj = (GameObject)Instantiate(obje);
        }
        
        
        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
