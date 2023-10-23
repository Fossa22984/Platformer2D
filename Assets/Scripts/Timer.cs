using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _timerText;

    public float ElapsedTime { get; private set; }

    void Update()
    {
        ElapsedTime += Time.deltaTime;
        _timerText.text = GetTimerText(ElapsedTime);
    }

    public string GetTimerText(float elapsedTime)
    {
        int minutes = Mathf.FloorToInt(elapsedTime / 60);
        int seconds = Mathf.FloorToInt(elapsedTime % 60);
        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
