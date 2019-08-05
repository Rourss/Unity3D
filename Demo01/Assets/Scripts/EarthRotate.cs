using UnityEngine;
using System.Collections;

public class EarthRotate : MonoBehaviour {

    public Transform sun;
	// Use this for initialization
    void Start()
    {

    }
	
	// Update is called once per frame
    void Update()
    {
        transform.RotateAround(sun.position, Vector3.up, 2f);
        transform.Rotate(Vector3.up, 1f);
    }
}
