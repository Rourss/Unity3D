using UnityEngine;
using System.Collections;

public class CubeMove : MonoBehaviour 
{

    private float speed;
    private float angleSpeed;
    // Use this for initialization
    void Start()
    {
        speed = 2f;
        angleSpeed = 15f;
    }
	
	// Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.W))
        //{
            //transform.Translate(Vector3.up * speed*Time.deltaTime);

        //}
        transform.Translate(Vector3.forward * Input.GetAxisRaw("Vertical") * speed * Time.deltaTime);
        transform.Rotate(Vector3.up * Input.GetAxisRaw("Horizontal") * angleSpeed * Time.deltaTime);
    }
}
