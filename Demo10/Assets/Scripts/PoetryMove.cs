using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PoetryMove : MonoBehaviour
{
    public string[] poetrys;
    public AudioClip[] poetryAudios;
    public int[] DisTime;
    
    void Start()
    {
        StartCoroutine(DisPoetry());
    }
    IEnumerator DisPoetry()
    {
        for(int i = 0; i < poetrys.Length; i++)
        {
            yield return new WaitForSeconds(DisTime[i]);
            GetComponent<Text>().text = poetrys[i];
            GetComponent<AudioSource>().clip = poetryAudios[i];
            GetComponent<AudioSource>().Play();
            if (i < poetrys.Length - 1)
            {
                GameObject.Find("1").GetComponent<Image>().enabled = true;
            }else
            {
                GameObject.Find("1").GetComponent<Image>().enabled = false;
            }
        }
    }
}
