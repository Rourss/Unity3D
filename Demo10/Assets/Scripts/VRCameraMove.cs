using UnityEngine;
using System.Collections;
using VRStandardAssets.Utils;

public class VRCameraMove : MonoBehaviour
{
    private Vector2 offest;
    private VREyeRaycaster hit;
    private float x;
    private float y;
    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        x = Input.GetAxis("Mouse X");
        y = Input.GetAxis("Mouse Y");
        offest.x += -y;
        offest.y += x;
        transform.eulerAngles = offest * 100f * Time.deltaTime;
        //transform.rotation=Quaternion.Euler(x*10f, y*10f, 0);
        //transform.Rotate(new Vector3(x, y, 0) * 100f * Time.deltaTime);
    }
}
