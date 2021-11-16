using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class guanqia3 : MonoBehaviour
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
        chance.GetComponent<Text>().text = "Chance:" + (7 - ScoreController.click);
        if (ScoreController.score1 >= 16)
        {
            if (ScoreController.click > 7)
            {
                lose.SetActive(true);
                arrowaa.GetComponent<JoyStick>().enabled = false;
                Invoke("Guanqia33", 2f);
            }
            if (ScoreController.click <= 7)
            {
                win.SetActive(true);
                arrowaa.GetComponent<JoyStick>().enabled = false;
                Invoke("Guanqia3", 1.5f);
            }
        }
        if (ScoreController.score1 <16)
        {
            if (ScoreController.click == 7)
            {
                lose.SetActive(true);
                arrowaa.GetComponent<JoyStick>().enabled = false;
                Invoke("Guanqia33", 2f);
            }
        }

    }
    void Guanqia3()
    {
        JoyStick.flag = true;
        ScoreController.click = 0;
        this.gameObject.GetComponent<ScoreController>().ClearScore();
        SceneManager.LoadScene("Scene4");
    }
    void Guanqia33()
    {
        JoyStick.flag = true;
        ScoreController.click = 0;
        this.gameObject.GetComponent<ScoreController>().ClearScore();
        SceneManager.LoadScene("Scene3");
    }
}
