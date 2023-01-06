using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : Item
{
    [SerializeField] int _healAmmount;
    [SerializeField] EntityHealth _playerHealth;
    public override void ApplyEffect()
    {
        _playerHealth.Heal(_healAmmount);
    }
}
