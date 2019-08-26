using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class VRButton : MonoBehaviour
{
    public Sprite overImage;
    public Sprite outImage;
    private RingMove publicRing;
    public GameObject ui;
    void Awake()
    {
        publicRing = gameObject.GetComponent<RingMove>()?? gameObject.AddComponent<RingMove>();
    }
    void OnEnable()
    {
        publicRing.publicOnOver += OnOver;
        publicRing.publicOnOut += OnOut;
        publicRing.publicLoad += Load;
    }
    void OnDisable()
    {
        publicRing.publicOnOver -= OnOver;
        publicRing.publicOnOut -= OnOut;
        publicRing.publicLoad -= Load;
    }
    void OnOver()
    {
        GetComponent<Image>().sprite = overImage;
    }
    void OnOut()
    {
        GetComponent<Image>().sprite = outImage;
    }
    void Load()
    {
        gameObject.GetComponent<BoxCollider>().enabled = false;
        Destroy(ui, 0.2f);
        GameObject.Find("JiaoHu").GetComponent<Animator>().enabled = true;
        GameObject.Find("WindowsBtn").GetComponent<BoxCollider>().enabled = true;
    }
}
