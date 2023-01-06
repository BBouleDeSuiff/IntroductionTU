using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimatorBinding : MonoBehaviour
{
    private Animator _playerAnimator;
    private GameObject _player;

    [SerializeField] PlayerMove _playermove;
    [SerializeField] PlayerAttack _playerAttack;
    [SerializeField] EntityHealth _playerHealth;

    void Awake()
    {
        _playerAnimator = gameObject.GetComponent<Animator>();
        _player = transform.parent.gameObject;

        _playerAttack.OnAttack += _playerAttack_OnAttack;

        _playerHealth.OnDamage += _playerHealth_OnDamage;

        _playermove.OnStartMove += _playermove_OnStartMove;
        _playermove.OnStopMove += _playermove_OnStopMove;
    }


    private void _playermove_OnStartMove()
    {
        _playerAnimator.SetBool("Walking", true);
    }
    private void _playermove_OnStopMove()
    {
        _playerAnimator.SetBool("Walking", false);
    }

    private void _playerAttack_OnAttack()
    {
        _playerAnimator.SetTrigger("Attack");
    }

    private void _playerHealth_OnDamage()
    {
        _playerAnimator.SetTrigger("GetHit");
    }


}
