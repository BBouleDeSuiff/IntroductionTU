using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : Item
{
    [SerializeField] int _powerUpAmmount;
    [SerializeField] EntityHealth _playerHealth;
    public override void ApplyEffect()
    {
        _playerHealth.MaxHealth += _powerUpAmmount;
    }
}
