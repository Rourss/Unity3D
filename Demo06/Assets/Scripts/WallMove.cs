using UnityEngine;
using System.Collections;

public class WallMove : MonoBehaviour
{
    private float heigth;
    public GameObject plan;
    // Use this for initialization
    void Start()
    {
        heigth = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(1, heigth, 1);
        heigth++;
    }
}
