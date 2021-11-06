using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Say1 : MonoBehaviour
{
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    [Header("UI组件")]
    public Text textLabel;

    [Header("文本文件")]
    public TextAsset textFile;
    public int index;
    List<string> textList = new List<string>();
    void Awake()
    {
        GetTextFormFile(textFile);
    }
    private void OnEnable()
    {
        textLabel.text = textList[index];
        index++;
    }
    // Start is called before the first frame update
    void Start()
    {
        p1.SetActive(false);
        p2.SetActive(false);
        p3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(index==8)
        {
            p1.SetActive(true);
        }
        if (index ==10)
        {
            p2.SetActive(true);
        }
        if (index == 12)
        {
            p3.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && index == textList.Count)//输出最后一行
        {
            SceneManager.LoadScene("Scene2");
            gameObject.SetActive(false);
            index = 0; 
            return;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            textLabel.text = textList[index];
            index++;
        }
    }
    void GetTextFormFile(TextAsset file)
    {
        textList.Clear();
        index = 0;
        var LineDate = file.text.Split('\n');
        foreach (var Line in LineDate)
        {
            textList.Add(Line);
        }
    }
}
