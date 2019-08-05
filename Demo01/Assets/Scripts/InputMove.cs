using UnityEngine;
using System.Collections;


public class InputMove : MonoBehaviour
{

    private float speed;
    private float angleSpeed;
    // Use this for initialization
    void Start()
    {
        speed = 1f;
        angleSpeed = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime);
        transform.Rotate(Vector3.left * Input.GetAxisRaw("Vertical") * angleSpeed * Time.deltaTime);
    }
}