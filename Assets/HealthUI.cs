using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Experimental.GraphView.GraphView;

public class HealthUI : MonoBehaviour
{

    [SerializeField] Slider _slider;
    [SerializeField] TextMeshProUGUI _text;
    [SerializeField] EntityHealth _playerHealth;
    int CachedMaxHealth
    {
        get { return _playerHealth.MaxHealth; }
        set { }
    }
    void Update()
    {
        UpdateSlider(_playerHealth.CurrentHealth);
    }
    void UpdateSlider(int newHealthValue)
    {
        _slider.maxValue = CachedMaxHealth;
        _slider.value = newHealthValue;
        _text.text = $"{newHealthValue} / {CachedMaxHealth}";
    }

}
