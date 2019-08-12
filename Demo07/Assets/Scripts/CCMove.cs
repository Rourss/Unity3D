using UnityEngine;
using System.Collections;

public class CCMove : MonoBehaviour
{

    private CharacterController CC;
    private Animator WuKong;
    private float speed;    
    // Use this for initialization
    void Start()
    {
        CC = GetComponent<CharacterController>();
        WuKong = GetComponent<Animator>();
        speed = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Vertical") != 0)
        {
            WuKong.SetBool("IsWalk", true);
            CC.SimpleMove(transform.forward * speed * Time.deltaTime * Input.GetAxisRaw("Vertical"));
        }
        if (Input.GetAxisRaw("Vertical") == 0)
        {
            WuKong.SetBool("IsWalk", false);
        }
        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            WuKong.SetBool("IsWalk", true);
            transform.Rotate(transform.up * speed * Time.deltaTime * Input.GetAxisRaw("Horizontal"));
        }
        if (Input.GetAxisRaw("Horizontal") == 0)
        {
            WuKong.SetBool("IsWalk", false);
        }
    }
}
