using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player.GetComponent<Jump>().enabled = false;
        player.GetComponent<citie>().enabled = false;
        GetComponent<Beat>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Jumps()
    {
        Jump.a = Random.Range(0, 4);
        player.GetComponent<Jump>().enabled = true;
        player.GetComponent<PlayerMove>().enabled = false;
        player.GetComponent<PlayerMove>().enabled = true;
        player.GetComponent<citie>().enabled = false;
        GetComponent<Beat>().enabled = false;
    }
    public void BeatM()
    {
        Jump.a = Random.Range(0, 4);
        GetComponent<Beat>().enabled = true;
        player.GetComponent<Jump>().enabled = false;
        player.GetComponent<citie>().enabled = false;
    }
    public void MagnetGold()
    {
        Jump.a = Random.Range(0, 4);
        player.GetComponent<citie>().enabled = true;
        GetComponent<Beat>().enabled = false;
        player.GetComponent<Jump>().enabled = false;
    }
}
