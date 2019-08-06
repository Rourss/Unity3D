using UnityEngine;
using System.Collections;

public class CubeMove : MonoBehaviour
{
    private float speed;
    private float anglSpeed;
    private Camera ThirdCamera;
    // Use this for initialization
    void Start()
    {
        speed = 50f;
        anglSpeed = 10f;
        ThirdCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime * Input.GetAxisRaw("Horizontal"));
        transform.Translate(Vector3.forward * anglSpeed * Time.deltaTime * Input.GetAxisRaw("Vertical"));
    }
    void LateUpdate()
    {
        //通过脚本让主摄像机跟着物体移动，但不改变跟着物体改变视角
        ThirdCamera.transform.position = transform.position + new Vector3(0, 1.96f, -14.45f);
    }
}
