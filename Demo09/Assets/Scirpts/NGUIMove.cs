using UnityEngine;
using System.Collections;

public class NGUIMove : MonoBehaviour
{

    private string str;
    private bool click;
    void Start()
    {
        str = "GAME OVER!";
        click = false;
    }
    void OnGUI()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            click = true;
            
        }
        if (click)
        {
            //GUILayout.Label(str, GUILayout.Width(100));
            GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 100, 100), "GAME OVER!");
            Time.timeScale = 0;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            click = false;
            Time.timeScale = 1;
        }


    }
}
