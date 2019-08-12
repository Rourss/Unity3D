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
    }
    void LateUpdate()
    {
        ver = game.transform.position;
        this.transform.localPosition = Vector3.Lerp(this.transform.position, ver + new Vector3(0, 3f, -4f), Time.deltaTime);
        
    }
}
