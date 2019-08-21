using UnityEngine;
using System.Collections;

public class LiBaiMove : MonoBehaviour
{
    private Animator libai;
    private bool isTrigger;
    // Use this for initialization
    void Start()
    {
        isTrigger = true;
        libai = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isTrigger)
        {
            //Youzhuan();
            transform.Rotate(Vector3.down * 70f );
            libai.SetBool("youzhuan",true);
        }
        isTrigger = false;

    }
    void Youzhuan()
    {
        transform.RotateAround(transform.position, new Vector3(0, -90, 0), Time.deltaTime * 100f);
    }
}
