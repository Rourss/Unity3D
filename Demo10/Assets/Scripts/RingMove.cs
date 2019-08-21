using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using VRStandardAssets.Utils;

public class RingMove : MonoBehaviour
{
    private  Image ring;
    private bool OnTrigger = false;
    private VRInteractiveItem activ;
    void Awake()
    {
        ring = GameObject.Find("ring").GetComponent<Image>();
        activ = gameObject.GetComponent<VRInteractiveItem>() ?? gameObject.AddComponent<VRInteractiveItem>();
        ring.fillAmount = 0;
    }
    void OnOver()
    {
        OnTrigger = true;
    }
    void OnOut()
    {
        OnTrigger = false;
        ring.fillAmount = 0;
    }
    void  Fill()
    {
        //if (OnTrigger)
        //{
            ring.fillAmount += Time.deltaTime / 2;
        //}
        
        if (ring.fillAmount == 1)
        {
            ring.fillAmount = 0;
        }
    }
    void Update()
    {
        Fill();
    }
}
