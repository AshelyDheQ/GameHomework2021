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
    public void AgainGame()
    {
        SceneManager.LoadScene("Scene2");
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Scene1");
    }
    public void Menu()
    {
        SceneManager.LoadScene("start");
    }
    public void End()
    {
        Application.Quit();
    }
}
