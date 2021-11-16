using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creatArrow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.tag == "WaveEnd")
        {
            this.gameObject.SetActive(false);
            this.gameObject.tag = "Start";
            GetComponent<CCAction>().enabled = false;
            GetComponent<PhysicalAction>().enabled = false;
        }
        if (this.gameObject.tag == "Start")
        {
            this.gameObject.SetActive(true);
            JoyStick.flag = true;
           GetComponent<CCAction>().enabled = true;
           GetComponent<PhysicalAction>().enabled = true;
            this.gameObject.tag = "Arrow";
            this.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            this.transform.position = new Vector3(2.3f, 2.5f, 0f);
        }
    }
}
