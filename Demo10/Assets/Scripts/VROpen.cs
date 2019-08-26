using UnityEngine;
using System.Collections;

public class VROpen : MonoBehaviour
{
    public RingMove publicRing;
    void Awake()
    {
        publicRing = gameObject.GetComponent<RingMove>() ?? gameObject.AddComponent<RingMove>();
    }
    void Load()
    {
        GetComponent<BoxCollider>().enabled = false;
        GameObject.Find("JiaoHu").GetComponent<Animator>().SetTrigger("Open");
    }
    void OnEnable()
    {
        publicRing.publicLoad += Load;
    }
    void OnDisable()
    {
        publicRing.publicLoad -= Load;
    }
}
