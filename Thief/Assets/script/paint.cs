using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class paint : MonoBehaviour
{
    public GameObject tip1;
    public GameObject tip2;
    public GameObject tip3;
    public GameObject tip4;
    public GameObject tip5;
    public GameObject paint1;
    public GameObject paint2;
    public GameObject paint3;
    public static int paintNum= 3;
    bool p1 = true;
    bool p2 = true;
    bool p3 = true;
    // Start is called before the first frame update
    void Start()
    {
        paintNum = 3;
        p1 = true;
        p2 = true;
        p3 = true;
        tip1.SetActive(false);
        tip2.SetActive(false);
        tip3.SetActive(false);
        tip4.SetActive(false);
        tip5.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E)&&tip1.activeSelf==true&&p1==true)
        {
            paint1.SetActive(false);
            paintNum -= 1;
            p1 = false;
        }
        if (Input.GetKey(KeyCode.E) && tip2.activeSelf == true && p2 == true)
        {
            paint2.SetActive(false);
            paintNum -= 1;
            p2 = false;
        }
        if (Input.GetKey(KeyCode.E) && tip3.activeSelf == true && p3 == true)
        {
            paint3.SetActive(false);
            paintNum -= 1;
            p3 = false;
        }
        if(Input.GetKey(KeyCode.R) && tip4.activeSelf == true)
        {
            SceneManager.LoadScene("Scene3");
        }
        if (Input.GetKey(KeyCode.R) && tip5.activeSelf == true)
        {
            SceneManager.LoadScene("Scene3");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="paint1")
        {
            tip1.SetActive(true);
        }
        if (other.gameObject.tag == "paint2")
        {
            tip2.SetActive(true);
        }
        if (other.gameObject.tag == "paint3")
        {
            tip3.SetActive(true);
        }
        if (other.gameObject.tag == "door")
        {
            tip4.SetActive(true);
        }
        if (other.gameObject.tag == "doors")
        {
            tip5.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "paint1")
        {
            tip1.SetActive(false);
        }
        if (other.gameObject.tag == "paint2")
        {
            tip2.SetActive(false);
        }
        if (other.gameObject.tag == "paint3")
        {
            tip3.SetActive(false);
        }
        if (other.gameObject.tag == "door")
        {
            tip4.SetActive(false);
        }
        if (other.gameObject.tag == "doors")
        {
            tip5.SetActive(false);
        }
    }
}
