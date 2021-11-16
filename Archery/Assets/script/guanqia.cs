using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class guanqia : MonoBehaviour
{
    public GameObject lose;
    public GameObject win;
    public GameObject arrowaa;
    public GameObject chance;
    // Start is called before the first frame update
    void Start()
    {
        lose.SetActive(false);
        win.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        chance.GetComponent<Text>().text = "Chance:" + (3- ScoreController.click);
        if (ScoreController.score1 >= 8)
        {
            if(ScoreController.click > 3)
            {
                lose.SetActive(true);
                arrowaa.GetComponent<JoyStick>().enabled = false;
                Invoke("Guanqia11", 2f);
            }
            if (ScoreController.click <= 3)
            {
                win.SetActive(true);
                arrowaa.GetComponent<JoyStick>().enabled = false;
                Invoke("Guanqia1", 1.5f);
            }
        }
       if(ScoreController.score1 < 8)
        {
            if (ScoreController.click== 3)
            {
                lose.SetActive(true);
                arrowaa.GetComponent<JoyStick>().enabled = false;
                Invoke("Guanqia11", 2f);
            }
        }
        
    }
    void Guanqia1()
    {
        JoyStick.flag = true;
        ScoreController.click = 0;
        this.gameObject.GetComponent<ScoreController>().ClearScore();
        SceneManager.LoadScene("Scene2");
    }
    void Guanqia11()
    {
        JoyStick.flag = true;
        ScoreController.click = 0;
        this.gameObject.GetComponent<ScoreController>().ClearScore();
        SceneManager.LoadScene("Scene1");
    }
}
