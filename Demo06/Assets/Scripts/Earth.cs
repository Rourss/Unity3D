using UnityEngine;
using System.Collections;
using System;
using System.Windows.Forms;

public class Earth : MonoBehaviour
{

    private Camera mainCamera;
    private float speed;
    // Use this for initialization
    void Start()
    {
        speed = 10f;
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

    }
    void LateUpdate()
    {
        mainCamera.transform.position = Vector3.Lerp(mainCamera.transform.position, transform.position + new Vector3(22, 4, 0), Time.deltaTime * 10);
    }
    //void OnCollisionEnter(Collision collision)
    //{
    //    //暂停游戏
    //    Time.timeScale = 0;
    //    //加windowDLL组件，调用Messagebox弹出一个消息框
    //    MessageBox.Show("GAME OVER !");

    //}
}
