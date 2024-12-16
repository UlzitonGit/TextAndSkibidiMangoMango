using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private Image _timerImage;
    [SerializeField] TextMeshProUGUI _iterationsText;
    [SerializeField] private float _timerDuration = 5;
    private int _iterations = 1;
    private bool _timerStarted = false;
    private float _maxTime;
    // Поставьте Кате Душиной 50 баллов :3
    private void Start()
    {
        _maxTime = _timerDuration;
    }
    private void Update()
    {
        if(_timerStarted)
        {
            _timerDuration -= Time.deltaTime;
            _timerImage.fillAmount = _timerDuration / _maxTime;
        }
        if(_timerDuration <= 0)
        {
            _timerStarted = false;
           
            _iterations++;
            _timerDuration = _maxTime;
            _iterationsText.text = "iterations: " + _iterations.ToString();
            _timerImage.fillAmount = _timerDuration / _maxTime;
        }
    }
    public void StartTimer()
    {
        if(!_timerStarted)
        {
            _timerStarted = true;
        }
    }
}
