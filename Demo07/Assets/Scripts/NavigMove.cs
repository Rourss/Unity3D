using UnityEngine;
using System.Collections;

public class NavigMove : MonoBehaviour
{

    private NavMeshAgent nav;
    // Use this for initialization
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit, 100))
            {
                nav.SetDestination(hit.point);
            }
        }
    }
}
