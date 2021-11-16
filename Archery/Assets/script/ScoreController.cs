using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public GameObject ScoreText;
    public GameObject ScoreText2;
    public static int score1=0;
    public static int click = 0;
    public void ClearScore()
    {
        score1 = 0;
    }
    public void AddScore(int score)
    {
        score1 += score;
        click += 1;
        ScoreText.GetComponent<Text>().text = "Score:" + score1;
        ScoreText2.GetComponent<Text>().text = "+" + score;
    }

    public int GetScore()
    {
        return score1;
    }
}
