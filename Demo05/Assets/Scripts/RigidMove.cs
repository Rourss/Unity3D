using UnityEngine;
using System.Collections;

public class RigidMove : MonoBehaviour
{

    private Rigidbody rigidBody;
    private Camera mainCamera;
    // Use this for initialization
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        //当按下W，对物体给一个脉冲力，瞬间的力，作用时间短
        if (Input.GetKeyDown(KeyCode.W))
        {
            rigidBody.AddForce(new Vector3(1, 1, 0) * 10, ForceMode.Impulse);
        }
        //当按下A，对物体给一个牵引力，持续不断给力，作用时间长
        if (Input.GetKey(KeyCode.A))
        {
            rigidBody.AddForce(new Vector3(1, 1, 0) * 10, ForceMode.Acceleration);
        }
        //当按下S，对物体给一个速度，跟脉冲力的效果是一样的
        if (Input.GetKey(KeyCode.S))
        {
            rigidBody.AddForce(new Vector3(1, 1, 0) * 50);
        }
    }
    void LateUpdate()
    {
        //设置主摄像头跟着物体移动，延迟时间移动
        mainCamera.transform.position = Vector3.Lerp(mainCamera.transform.position, transform.position + new Vector3(0, 1, -10), Time.deltaTime * 10);
    }
}
