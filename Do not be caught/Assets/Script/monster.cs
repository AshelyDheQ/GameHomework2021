using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class monster : MonoBehaviour
{
    public GameObject mons;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

        if (transform.position.x > 30 || transform.position.x < -10)
        {
           mons.SetActive(false) ;//Ïú»Ù
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Scene3");
        }
    }
}
