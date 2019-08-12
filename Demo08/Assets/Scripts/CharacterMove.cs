using UnityEngine;
using System.Collections;

public class CharacterMove : MonoBehaviour {

    private float speed;
    private float angspeed;
    private float ver;
    private float hor;
    private Animator ObjGame;
	// Use this for initialization
	void Start () {
        speed = 10f;
        angspeed = 100f;
        ObjGame = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void FixedUpdate()
    {
        ver = Input.GetAxisRaw("Vertical");
        hor = Input.GetAxisRaw("Horizontal");
        if (ver > 0)
        {
            ObjGame.SetBool("IsWalk", true);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                ObjGame.SetBool("IsRun", true);
            }
            else
            {
                ObjGame.SetBool("IsRun", false);
            }
        }
        else if (ver < 0)
        {
            ObjGame.SetBool("IsWalkBack", true);
            ObjGame.SetBool("IsRun", false);
        }
        else
        {
            ObjGame.SetBool("IsWalk", false);
            ObjGame.SetBool("IsWalkBack", false);
            ObjGame.SetBool("IsRun", false);
        }

        if (hor > 0)
        {
            ObjGame.SetBool("IsWalkR", true);
        }
        else if (hor < 0)
        {
            ObjGame.SetBool("IsWalkL", true);
        }
        else
        {
            ObjGame.SetBool("IsWalkR", false);
            ObjGame.SetBool("IsWalkL", false);
        }
        
    }
}
