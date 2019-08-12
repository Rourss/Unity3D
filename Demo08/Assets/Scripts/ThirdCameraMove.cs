using UnityEngine;
using System.Collections;

public class ThirdCameraMove : MonoBehaviour
{

    public GameObject game;
    private Vector3 ver;
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ver = new Vector3();
        ver = game.transform.position;
    }
    void LateUpdate()
    {
        this.transform.position = Vector3.Lerp(this.transform.position, ver + new Vector3(0, 2f, -5f), Time.deltaTime);
    }
}
