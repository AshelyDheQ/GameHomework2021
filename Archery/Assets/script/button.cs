using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  public  void startGame()
    {
        SceneManager.LoadScene("Scene1");
    }
   public void endGame()
    {
        Application.Quit();
    }
    public void returnGame()
    {
        SceneManager.LoadScene("Scene0");
    }
}
