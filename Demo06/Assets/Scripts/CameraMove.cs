using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour
{
    private float x;
    private float y;
    // Use this for initialization
    void Start()
    {
        x = 0;
        y = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            x = Input.GetAxis("Mouse X");
            y = Input.GetAxis("Mouse Y");
            this.transform.RotateAround(this.transform.position, Vector3.up, Time.deltaTime * x * 50f);
            this.transform.RotateAround(this.transform.position, this.transform.right, Time.deltaTime * y * 50f);
        }
    }
}
