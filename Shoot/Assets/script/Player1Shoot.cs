using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player1Shoot : MonoBehaviour
{
    public float speed;//�ӵ��ٶ�
    public Rigidbody2D zidan;//�ӵ�
    public Transform weizhi;//λ��
    public Transform player1;//���һλ��
    public Transform player2;//��Ҷ�λ��
    public Slider HP1;//���һѪ��
    public Slider HP2;//��Ҷ�Ѫ��
    public GameObject win1;//���һʤ��ͼ
    public GameObject player22;
    public GameObject buttonAgain;//���¿�ʼ��ť
    public GameObject buttonReturn;//���ز˵���ť
    public Text text1;//����
    public AudioClip audio1;//ǹ����Ч
    public GameObject fangyu1;//����
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
        if(Input.GetKeyDown(KeyCode.Space))//�ո�������ӵ�
        {
            GetComponent<AudioSource>().clip = audio1;
            GetComponent<AudioSource>().Play();//����
            Rigidbody2D clone;
            clone = (Rigidbody2D)Instantiate(zidan, weizhi.position,weizhi.rotation);//��¡�ӵ���Ԥ���壬��¡����λ�ã��Ƕȣ�
            if (player1.position.x<player2.position.x)
            {
                clone.velocity = new Vector2(+speed, 0);//���ӵ������ٶ�
            }
            else if(player1.position.x >player2.position.x)
            {
                clone.velocity = new Vector2(-speed, 0);
            }
        }
        if(Input.GetKeyDown(KeyCode.LeftAlt))//��ALT����
        {
            fangyu1.SetActive(true);
            Invoke("xiaoshi", 2.0f);
        }
        if (Input.GetKeyUp(KeyCode.LeftAlt))//��ALT����
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
