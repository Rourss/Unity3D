using UnityEngine;
using System.Collections;

public class ColliderMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    //当前物体跟另一个物体发生碰撞时，进行检测
    //Enter是刚碰到，Stay是在碰到后没离开时，Exit是离开后
    //该方法是检测刚碰到时
    void OnCollisionEnter(Collision collision)
    {
        //当碰到该物体，销毁它
        Destroy(collision.gameObject);
    }
}
