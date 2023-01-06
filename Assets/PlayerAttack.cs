using NaughtyAttributes;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using static UnityEditor.Experimental.GraphView.GraphView;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] float _attackDuration;
    GameObject _attackField;


    public InputActionReference _attack;

    public event Action OnAttack;

    [SerializeField] UnityEvent _onAttack;


    private void Start()
    {
        _attack.action.started += Attack;
        _attackField = transform.Find("Physics/AttackRange").gameObject;
        _attackField.SetActive(false);
    }

    private void OnDestroy()
    {
        _attack.action.started -= Attack;
    }

    private void Attack(InputAction.CallbackContext obj)
    {
        OnAttack?.Invoke();
        _onAttack?.Invoke();
        StartCoroutine(UpdateAttackField());
    }
    IEnumerator UpdateAttackField()
    {
        _attackField.SetActive(true);
        yield return new WaitForSeconds(_attackDuration);
        _attackField.SetActive(false);
    }

}
