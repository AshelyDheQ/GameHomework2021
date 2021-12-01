using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Collection : MonoBehaviour
{
    public GameObject text;
    public static float num=26;
    public GameObject door;
    public GameObject doortips;
    public GameObject doortipss;
    public GameObject pumpkin;
    // Start is called before the first frame update
    void Start()
    {
        num = 26;
        doortips.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        text.GetComponent<Text>().text = "Pumpkin£º" + num;
        if(num<=0)
        {
            num = 0;
                Destroy(pumpkin.gameObject);
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Collect")
        {
            Destroy(other.gameObject);
            num -= 1;
        }
        if (other.gameObject.tag == "door")
        {
            SceneManager.LoadScene("Scene2");
        }
        if (other.gameObject.tag == "doortips")
        {
            doortips.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "doortips")
        {
            doortips.SetActive(false);
        }
    }
}
