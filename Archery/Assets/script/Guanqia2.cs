using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Guanqia2 : MonoBehaviour
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
        chance.GetComponent<Text>().text = "Chance:" + (5 - ScoreController.click);
        if (ScoreController.score1 >= 14)
        {
            if (ScoreController.click >5)
            {
                lose.SetActive(true);
                arrowaa.GetComponent<JoyStick>().enabled = false;
                Invoke("guanqia22", 2f);
            }
            if (ScoreController.click <= 5)
            {
                win.SetActive(true);
                arrowaa.GetComponent<JoyStick>().enabled = false;
                Invoke("guanqia2", 1.5f);
            }
        }
        if (ScoreController.score1 < 14)
        {
            if (ScoreController.click == 5)
            {
                lose.SetActive(true);
                arrowaa.GetComponent<JoyStick>().enabled = false;
                Invoke("guanqia22", 2f);
            }
        }
    }
    void guanqia2()
    {
        JoyStick.flag = true;
        ScoreController.click = 0;
        this.gameObject.GetComponent<ScoreController>().ClearScore();
        SceneManager.LoadScene("Scene3");
    }
    void guanqia22()
    {
        JoyStick.flag = true;
        ScoreController.click = 0;
        this.gameObject.GetComponent<ScoreController>().ClearScore();
        SceneManager.LoadScene("Scene2");
    }
}
