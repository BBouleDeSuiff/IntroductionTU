using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;
using UnityEngine.Events;
using UnityEngine.InputSystem;



public class GoldUI : MonoBehaviour
{
    [SerializeField] TMP_Text goldText;
    [SerializeField] EntityGold playerGold;

    UnityEvent onGoldChange;

    private void Awake()
    {

    }

    void Start()
    {
        playerGold.GoldChanged += PlayerGold_GoldChanged;
    }

    private void PlayerGold_GoldChanged(int obj)
    {
        goldText.text = "Gold : " + obj.ToString();
    }

    void Update()
    {
        
    }

}
