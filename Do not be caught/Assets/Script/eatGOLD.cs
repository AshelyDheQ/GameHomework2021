using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class eatGOLD : MonoBehaviour
{
    public int gold = 4;
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="gold")
        {
            Destroy(collision.gameObject);
            gold--;
            text.GetComponent<Text>().text = "±ý¸É£º" + gold;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(gold==0)
        {
            if(collision.gameObject.tag=="end")
            {
                SceneManager.LoadScene("Scene4");
            }
        }
        
    }
  
}
