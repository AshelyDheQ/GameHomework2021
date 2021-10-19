using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player1Shoot : MonoBehaviour
{
    public float speed;//子弹速度
    public Rigidbody2D zidan;//子弹
    public Transform weizhi;//位置
    public Transform player1;//玩家一位置
    public Transform player2;//玩家二位置
    public Slider HP1;//玩家一血条
    public Slider HP2;//玩家二血条
    public GameObject win1;//玩家一胜利图
    public GameObject player22;
    public GameObject buttonAgain;//重新开始按钮
    public GameObject buttonReturn;//返回菜单按钮
    public Text text1;//分数
    public AudioClip audio1;//枪声音效
    public GameObject fangyu1;//防御
    private float score = 0;
    // Start is called before the first frame update
    void Start()
    {
        HP1.value = 1;
        win1.SetActive(false);
        buttonAgain.SetActive(false);
        buttonReturn.SetActive(false);
        fangyu1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))//空格键发射子弹
        {
            GetComponent<AudioSource>().clip = audio1;
            GetComponent<AudioSource>().Play();//播放
            Rigidbody2D clone;
            clone = (Rigidbody2D)Instantiate(zidan, weizhi.position,weizhi.rotation);//克隆子弹（预制体，克隆出的位置，角度）
            if (player1.position.x<player2.position.x)
            {
                clone.velocity = new Vector2(+speed, 0);//给子弹赋给速度
            }
            else if(player1.position.x >player2.position.x)
            {
                clone.velocity = new Vector2(-speed, 0);
            }
        }
        if(Input.GetKeyDown(KeyCode.LeftAlt))//左ALT防御
        {
            fangyu1.SetActive(true);
            Invoke("xiaoshi", 2.0f);
        }
        if (Input.GetKeyUp(KeyCode.LeftAlt))//左ALT防御
        {
            fangyu1.SetActive(false);
        }
        if (HP1.value < 0)
        {
            
            score += 1;
            text1.text = score.ToString();
            HP1.value = 1;
            HP2.value = 1;
            player2.position = new Vector3(8.11f,1.28f,0);
            player1.position= new Vector3(-8.18f, -0.59f, 0);
            if (score==2)
            {
                win1.SetActive(true);
                buttonAgain.SetActive(true);
                buttonReturn.SetActive(true);
                player22.GetComponent<Player2Move>().enabled = false;
                player22.GetComponent<Player2Shoot>().enabled = false;
                GetComponent<Player1Shoot>().enabled = false;
                GetComponent<Player1Move>().enabled = false;
            }
           
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="zidan2")
        {
            Destroy(other.gameObject);
            HP1.value -= 0.2f;
        }
       
    }

    void xiaoshi()
    {
        fangyu1.SetActive(false);
    }
}
