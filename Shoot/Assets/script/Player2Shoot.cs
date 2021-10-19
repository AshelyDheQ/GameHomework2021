using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2Shoot : MonoBehaviour
{
    public float speed;//子弹速度
    public Rigidbody2D zidan;//子弹
    public Transform weizhi;//位置
    public Transform player1;//玩家一位置
    public Transform player2;//玩家二位置
    public Slider HP1;//玩家一血条
    public Slider HP2;//玩家二血条
    public GameObject win2;//玩家一胜利图
    public GameObject player11;
    public GameObject buttonAgain;//重新开始按钮
    public GameObject buttonReturn;//返回菜单按钮
    public Text text2;//分数
    public AudioClip audio2;//枪声音效
    public GameObject fangyu2;//防御
    private float score = 0;

    // Start is called before the first frame update
    void Start()
    {
        HP2.value = 1;
        win2.SetActive(false);
        buttonAgain.SetActive(false);
        buttonReturn.SetActive(false);
        fangyu2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightAlt))//右alt键发射子弹
        {
            GetComponent<AudioSource>().clip = audio2;
            GetComponent<AudioSource>().Play();//播放
            Rigidbody2D clone;
            clone = (Rigidbody2D)Instantiate(zidan, weizhi.position, weizhi.rotation);//克隆子弹（预制体，克隆出的位置，角度）
            if (player2.position.x < player1.position.x)
            {
                clone.velocity = new Vector2(+speed, 0);//给子弹赋给速度
            }
            else if (player2.position.x > player1.position.x)
            {
                clone.velocity = new Vector2(-speed, 0);
            }
        }
        if (Input.GetKeyDown(KeyCode.RightControl))//右ctrl防御
        {
            fangyu2.SetActive(true);
            Invoke("xiaoshi", 2.0f);//延时消失
        }
        if (Input.GetKeyUp(KeyCode.RightControl))//右ctrl防御
        {
            fangyu2.SetActive(false);
        }
        if (HP2.value<0)
        {
            score += 1;
            text2.text = score.ToString();
            HP1.value = 1;
            HP2.value = 1;
            player2.position = new Vector3(8.11f, 1.28f, 0);
            player1.position = new Vector3(-8.18f, -0.59f, 0);
            if(score==2)
            {
                win2.SetActive(true);
                buttonAgain.SetActive(true);
                buttonReturn.SetActive(true);
                player11.GetComponent<Player1Move>().enabled = false;
                player11.GetComponent<Player1Shoot>().enabled = false;
                GetComponent<Player2Shoot>().enabled = false;
                GetComponent<Player2Move>().enabled = false;
            }
            
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "zidan1")
        {
            Destroy(other.gameObject);
            HP2.value -= 0.20f;
        }
    }
    void xiaoshi()
    {
        fangyu2.SetActive(false);
    }
}
