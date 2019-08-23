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
        publicRing.publicLoad += Load;
        publicRing.publicOnOut += OnOut;
    }
    void OnDisable()
    {
        publicRing.publicOnOver -= OnOver;
        publicRing.publicLoad -= Load;
        publicRing.publicOnOut -= OnOut;
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
        if(publicRing)
        Destroy(ui, 0.1f);
    }
}
