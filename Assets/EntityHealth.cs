using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EntityHealth : MonoBehaviour
{

    public int _maxHealth;

    public event Action OnDamage;
    public int CurrentHealth { get; private set; }

    private void Awake()
    {
        CurrentHealth = _maxHealth;
    }
    private void Update()
    {
        if(CurrentHealth <= 0)
            Destroy(gameObject);
    }
    public void TakeDamage(int damage)
    {
        OnDamage?.Invoke();
        CurrentHealth -= damage;
    }

}
