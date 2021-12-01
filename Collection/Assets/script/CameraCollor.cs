using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCollor : MonoBehaviour
{
    private float mouseX, mouseY;//��ȡ����ƶ���ֵ
    public float mouseSensitivity;//���������
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        player.Rotate(Vector3.up * mouseX);
    }
}
