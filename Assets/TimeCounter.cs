﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeCounter : MonoBehaviour
{
    //カウントダウン
    public float countdown = 5.0f;

    //時間を表示するText型の変数
    public Text timeText;
    public Text timeupText;

    // Update is called once per frame
    void Update()
    {
        //時間をカウントダウンする
        countdown -= Time.deltaTime;

        //時間を表示する
        timeText.text = countdown.ToString("f1") + "秒";

        if (countdown <= 0.0f)
        {
            SceneManager.LoadScene(2);
        }

    }
}