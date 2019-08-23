using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using VRStandardAssets.Utils;
using System;

public class RingMove : MonoBehaviour
{
    private  Image ring;
    private bool onTrigger = false;
    private VRInteractiveItem activ;
    public event Action publicOnOver;
    public event Action publicOnOut;
    public event Action publicLoad;
    void Awake()
    {
        ring = GameObject.Find("ring").GetComponent<Image>();
        activ = gameObject.GetComponent<VRInteractiveItem>() ?? gameObject.AddComponent<VRInteractiveItem>();
        ring.fillAmount = 0;
    }
    void OnEnable()
    {
        activ.OnOver += OnOver;
        activ.OnOut += OnOut;
    }
    void OnDisble()
    {
        activ.OnOver -= OnOver;
        activ.OnOut -= OnOut;
    }
    void OnOver()
    {
        onTrigger = true;
        if(publicOnOver!=null)
        {
            publicOnOver();
        }
    }
    void OnOut()
    {
        onTrigger = false;
        ring.fillAmount = 0;
        if (publicOnOut != null)
        {
            publicOnOut();
        }
    }
   public void  Fill()
    {
        if (onTrigger)
        {
            ring.fillAmount += Time.deltaTime / 2;
        }

        if (ring.fillAmount == 1)
        {
            ring.fillAmount = 0;
        }
        if (publicLoad != null)
        {
            publicLoad();
        }
    }
    void Update()
    {
        Fill();
    }
}
