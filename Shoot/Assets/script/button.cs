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
    public void OnclickAgain()//���¿�ʼ
    {
        SceneManager.LoadScene("Scene1");
    }
    public void OnclickReturn()//���ز˵�
    {
        SceneManager.LoadScene("SceneStart");
    }
    public void OnclickStart()//��ʼ��Ϸ
    {
        SceneManager.LoadScene("Scene1");
    }
    public void OnclickInstuct()//�淨˵��
    {
        instruction.SetActive(true);
        retuen.SetActive(true);
    }
    public void OnclickInstuctRe()//�˳��淨˵��
    {
        instruction.SetActive(false);
        retuen.SetActive(false);
    }
    public void OnclickEnd()//�˳���Ϸ
    {
        Application.Quit();
    }

}
