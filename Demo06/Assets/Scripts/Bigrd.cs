using UnityEngine;
using System.Collections;

public class Bigrd : MonoBehaviour
{
    private float speed;
    public GameObject wall;
    private Rigidbody rig;
    // Use this for initialization
    void Start()
    {
        speed = 20f;
        wall = GetComponent<GameObject>();
        rig = GetComponent<Rigidbody>();
    }
    #region
    // Update is called once per frame
    void Update()
    {
    }
    #endregion
    void OnCollisionEnter(Collision collision)
    {
        rig.AddForce(Vector3.right * speed);
        //transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
