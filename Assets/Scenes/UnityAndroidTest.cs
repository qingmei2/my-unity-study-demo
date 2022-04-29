using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnityAndroidTest: MonoBehaviour
{
    public Text text1;

    // Start is called before the first frame update
    void Start()
    {
        AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject>("currentActivity");

        int res = 0;

        try
        {
            res = jo.Call<int>("increment", 2);
            text1.text = res.ToString();
        }
        catch (Exception e)
        {
            text1.text = "error";
        }
    }

    // java代码，直接放入Android工程
    //private int count = 1;

    //public int increment(int step)
    //{
    //    UnityPlayer.UnitySendMessage("Canvas", "ChangeColor", "");
    //    count += step;
    //    return count;
    //}

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeColor()
    {
        text1.color = Color.red;
    }
}
