using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Temporizer : MonoBehaviour
{
    //segundos -> minutos
    public int Seconds;
    [Range(-1, 1)]
    public float timeScale = 1;
    public Text timerText;

    float timeInSeconds = 0f;

    public bool myLock;

    private void Start()
    {
        timeInSeconds = Seconds;
        UpdateTime(Seconds);
    }

    private void Update()
    {
        if (myLock)
        {
            timeInSeconds += (Time.deltaTime + timeScale);
            UpdateTime(timeInSeconds);
        }
        else
        {
            timeInSeconds = Seconds;
        }
    }

    public void UpdateTime(float _timeInSeconds)
    {
        int minutes = 0;
        int seconds = 0;

        string _timerText;

        if (_timeInSeconds < 0) _timeInSeconds = 0;

        minutes = (int)_timeInSeconds / 60;
        seconds = (int)_timeInSeconds % 60;

        _timerText = minutes.ToString("00") + ":" + seconds.ToString("00");

        timerText.text = _timerText;

    }



}
