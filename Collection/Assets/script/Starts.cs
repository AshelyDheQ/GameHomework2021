using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Starts : MonoBehaviour
{
    public GameObject canvass;
    public GameObject timess;
    public GameObject players;
    public GameObject nursess;
    public GameObject camerass;
    private Rigidbody rigi;
    // Start is called before the first frame update
    void Start()
    {
        rigi = players.GetComponent<Rigidbody>();
        rigi.constraints = RigidbodyConstraints.FreezeAll;
        timess.GetComponent<timesDao>().enabled = false;
        nursess.GetComponent<NurseMove>().enabled = false;
        players.GetComponent<PlayerMove>().enabled = false;
        camerass.GetComponent<CameraCollor>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void startss()
    {
        rigi.constraints = RigidbodyConstraints.None;
        rigi.constraints = RigidbodyConstraints.FreezeRotation;
        timess.GetComponent<timesDao>().enabled = true;
        nursess.GetComponent<NurseMove>().enabled = true;
        players.GetComponent<PlayerMove>().enabled = true;
        camerass.GetComponent<CameraCollor>().enabled = true;
        Destroy(canvass.gameObject);
    }
}
