using UnityEngine;
using System.Collections;

public class ProjectInsta : MonoBehaviour
{

    public GameObject RBK;
    private GameObject Rbk;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Rbk=Instantiate(RBK);
            Rbk.transform.position = Vector3.zero;
            Rbk.AddComponent<CubeMove>();

        }
        if (Input.GetMouseButtonDown(1))
        {
            CubeMove cm= Rbk.GetComponent<CubeMove>();
            Destroy(cm);
            //Destroy(Rbk,2);
        }
    }
}
