using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NurseMove : MonoBehaviour
{
    public Transform player;
    public float minDist;
    public float movespeed;
    private bool stops=true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player);
        if(Vector3.Distance(transform.position,player.position)>=minDist)
        {
            transform.position += transform.forward * movespeed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.Space)&&stops==true)
        {
            movespeed = 0;
            this.GetComponent<AudioSource>().volume = 0;
            stops = false;
            Invoke("Huifu", 10f);
        }
    }
    void Huifu()
    {
        stops = true;
        this.GetComponent<AudioSource>().volume = 1;
        movespeed = 10;
    }
}
