using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2Shoot : MonoBehaviour
{
    public float speed;//�ӵ��ٶ�
    public Rigidbody2D zidan;//�ӵ�
    public Transform weizhi;//λ��
    public Transform player1;//���һλ��
    public Transform player2;//��Ҷ�λ��
    public Slider HP1;//���һѪ��
    public Slider HP2;//��Ҷ�Ѫ��
    public GameObject win2;//���һʤ��ͼ
    public GameObject player11;
    public GameObject buttonAgain;//���¿�ʼ��ť
    public GameObject buttonReturn;//���ز˵���ť
    public Text text2;//����
    public AudioClip audio2;//ǹ����Ч
    public GameObject fangyu2;//����
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
        if (Input.GetKeyDown(KeyCode.RightAlt))//��alt�������ӵ�
        {
            GetComponent<AudioSource>().clip = audio2;
            GetComponent<AudioSource>().Play();//����
            Rigidbody2D clone;
            clone = (Rigidbody2D)Instantiate(zidan, weizhi.position, weizhi.rotation);//��¡�ӵ���Ԥ���壬��¡����λ�ã��Ƕȣ�
            if (player2.position.x < player1.position.x)
            {
                clone.velocity = new Vector2(+speed, 0);//���ӵ������ٶ�
            }
            else if (player2.position.x > player1.position.x)
            {
                clone.velocity = new Vector2(-speed, 0);
            }
        }
        if (Input.GetKeyDown(KeyCode.RightControl))//��ctrl����
        {
            fangyu2.SetActive(true);
            Invoke("xiaoshi", 2.0f);//��ʱ��ʧ
        }
        if (Input.GetKeyUp(KeyCode.RightControl))//��ctrl����
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
