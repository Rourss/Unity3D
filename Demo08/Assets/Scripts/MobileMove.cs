using UnityEngine;
using System.Collections;

public class MobileMove : MonoBehaviour
{

    private float speed;
    private float angSpeed;
    // Use this for initialization
    void Start()
    {
        speed = 1f;
        angSpeed = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime * Input.GetAxisRaw("Vertical"));
        transform.Rotate(Vector3.up * angSpeed * Time.deltaTime * Input.GetAxisRaw("Horizontal"));
    }
}
