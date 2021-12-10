using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCollor : MonoBehaviour
{
    private float mouseX, mouseY;//��ȡ����ƶ���ֵ
    public float mouseSensitivity;//���������
    public Transform player;
    public float xRotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -70f, 70f);
        player.Rotate(Vector3.up * mouseX);
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
    }
}
