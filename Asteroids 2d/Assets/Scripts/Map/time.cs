using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class time : MonoBehaviour
{
    private float seconds;
    private float minutes;
    private float hours;

    public Text timeText;

    private void Start()
    {
        seconds = 0;
        minutes = 0;
        hours = 0;
    }

    private void Update()
    {
        seconds += Time.deltaTime;
        if (seconds >= 60)
        {
            print("60 seconds");
            seconds = 0;
            minutes++;
        }
        if (minutes >= 60)
        {
            print("60 minutes");
            minutes = 0;
            hours++;
        }
        timeText.text = hours.ToString("00") + ":" + minutes.ToString("00") + ":" + seconds.ToString("00");
    }
}
