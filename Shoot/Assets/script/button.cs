using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{
    public GameObject instruction;
    public GameObject retuen;
    // Start is called before the first frame update
    void Start()
    {
        instruction.SetActive(false);
        retuen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnclickAgain()//重新开始
    {
        SceneManager.LoadScene("Scene1");
    }
    public void OnclickReturn()//返回菜单
    {
        SceneManager.LoadScene("SceneStart");
    }
    public void OnclickStart()//开始游戏
    {
        SceneManager.LoadScene("Scene1");
    }
    public void OnclickInstuct()//玩法说明
    {
        instruction.SetActive(true);
        retuen.SetActive(true);
    }
    public void OnclickInstuctRe()//退出玩法说明
    {
        instruction.SetActive(false);
        retuen.SetActive(false);
    }
    public void OnclickEnd()//退出游戏
    {
        Application.Quit();
    }

}
