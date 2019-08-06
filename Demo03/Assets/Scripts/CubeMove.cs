using UnityEngine;
using System.Collections;

public class CubeMove : MonoBehaviour
{
    private float speed;
    private float anglSpeed;
    // Use this for initialization
    void Start()
    {
        speed = 50f;
        anglSpeed = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime * Input.GetAxisRaw("Horizontal"));
        transform.Translate(Vector3.forward * anglSpeed * Time.deltaTime * Input.GetAxisRaw("Vertical"));
    }
}
