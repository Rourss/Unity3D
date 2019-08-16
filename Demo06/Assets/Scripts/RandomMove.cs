using UnityEngine;
using System.Collections;

public class RandomMove : MonoBehaviour
{
    public GameObject plan;
    private GameObject plans;
    private Vector3 vec;
    private float weigth;
    private float heigth;
    // Use this for initialization
    void Start()
    {
        heigth = -5;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            vec = new Vector3(Random.Range(-5, 5), heigth, 0);
            heigth -= 8;
            for (int i = 0; i < 2; i++)
            {
                plans = Instantiate(plan);
                plans.transform.position = vec;
            }
                   InvokeRepeating("DestroyPlan", 0,0.1f);
        }

      
    }
    void DestroyPlan()
    {
        Destroy(plans, 1);
    }
}
