using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonNomal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AgainGame()
    {
        SceneManager.LoadScene("Scene2");
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Scene1");
    }
    public void ReturnGame()
    {
        SceneManager.LoadScene("Start");
    }
    public void endGame()
    {
        Application.Quit();
    }
}
