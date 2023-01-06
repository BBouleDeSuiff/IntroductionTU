using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Assertions;

public class EntityHealth : MonoBehaviour
{

    [SerializeField] int _maxHealth;
    public int MaxHealth
    {
        get { return _maxHealth; }
        set { _maxHealth = value; }
    }

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

    public void Heal(int ammount)
    {
        Debug.Assert(ammount >= 0);
        CurrentHealth += ammount;
        CurrentHealth = Mathf.Clamp(CurrentHealth, 0, MaxHealth);
    }
    public void TakeDamage(int damage)
    {
        Debug.Assert(damage >= 0);
        OnDamage?.Invoke();
        CurrentHealth -= damage;
        CurrentHealth = Mathf.Clamp(CurrentHealth, 0, MaxHealth);
    }

}
