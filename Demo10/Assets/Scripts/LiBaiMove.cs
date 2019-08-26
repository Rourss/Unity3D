using UnityEngine;
using System.Collections;

public class LiBaiMove : MonoBehaviour
{
    private Animator libai;
    private bool isTrigger;
    private bool stop;
    private bool start;
    private float speed;
    private int vec;
    public GameObject Poetry_UI;
    // Use this for initialization
    void Start()
    {
        speed =1f;
        isTrigger = true;
        stop = true;
        start = false;
        libai = GetComponent<Animator>();
        StartCoroutine(CreatPoetry());
    }

    IEnumerator CreatPoetry()
    {
        yield return new WaitForSeconds(2);
        Instantiate(Poetry_UI);
    }
   // Update is called once per frame
    void Update()
    {
        YouShen();
        Zoulu();
        Zuozhuan();


    }
    void YouShen()
    {
        if (isTrigger)
        {
            //Youzhuan();
            libai.SetBool("youzhuan",true);
            transform.Rotate(Vector3.down * 90f);
            //transform.Rotate(0, - (num* Time.deltaTime *20f), 0);
            isTrigger = false;
        }
        
    }
    void Zoulu()
    {
        if (stop)
        {
            vec = Mathf.RoundToInt(transform.position.x);
            if (vec <= -3)
            {
                stop = false;
                libai.SetBool("youzhuan", false);
            }
            else
            {
                libai.SetFloat("zoulu", speed);
                transform.Translate(Vector3.forward * speed * Time.deltaTime);
            }
        }
    }
    void Zuozhuan()
    {
        if (start == false && stop == false)
        {
            libai.SetBool("zuozhuan", true);
            transform.Rotate(Vector3.down * 90f);
            libai.SetBool("zuozhuan", false);
            start = true;
        }
        
    }
}
