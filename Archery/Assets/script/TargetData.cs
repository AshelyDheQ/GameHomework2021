using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetData : MonoBehaviour
{
    // ���ص�Target�ϵ�ÿһ�����������ظû���Ӧ�ķ�����
    public int GetScore()
    {
        string name = this.gameObject.name;
        int score = 7 - (name[0] - '0');
        return score;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
