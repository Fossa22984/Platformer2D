using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using TMPro;
using System;

public class WinPanel : MonoBehaviour
{
    [SerializeField] private GameObject _panel;

    [SerializeField] private TextMeshProUGUI _timerText;
    [SerializeField] private TextMeshProUGUI _redDiamonds;
    [SerializeField] private TextMeshProUGUI _blueDiamonds;


    public void ShowPanel(string timerText, string redDiamonds, string blueDiamonds)
    {
        _timerText.text = timerText;
        _redDiamonds.text = redDiamonds;
        _blueDiamonds.text = blueDiamonds;

        _panel.SetActive(true);
    }
}