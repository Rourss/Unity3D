using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour
{
    private float offest; //偏移量
    private float mobile; //移动量
    public Transform target; //目标
    // Use this for initialization
    void Start()
    {
        offest = 5f;
        mobile = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void LateUpdate()
    {
        Vector3 targetPostion = target.position + Vector3.up * offest - Vector3.forward * offest;
        transform.position = Vector3.Lerp(transform.position, targetPostion, mobile);
        //if (Input.GetMouseButton(1))
        //{
        //    x = Input.GetAxis("Mouse X");
        //    y = Input.GetAxis("Mouse Y");
        //    this.transform.RotateAround(this.transform.position, Vector3.up, Time.deltaTime * x * 50f);
        //    this.transform.RotateAround(this.transform.position, this.transform.right, Time.deltaTime * y * 50f);
        //}
        //让摄像机一直在物体的上方，并跟随物体
        transform.LookAt(target.position);

    }
}
