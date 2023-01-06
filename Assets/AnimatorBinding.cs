using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimatorBinding : MonoBehaviour
{
    private Animator _playerAnimator;
    private GameObject _player;

    private Vector2 MoveValues   
    {
        get { return _player.GetComponent<PlayerMove>().JoystickDirection; }
    }

    // Start is called before the first frame update
    void Awake()
    {
        _playerAnimator = gameObject.GetComponent<Animator>();
        _player = transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        SetWalking();
    }
    void SetWalking()
    {
        if (MoveValues.x > 0.1f || MoveValues.x < -0.1f || MoveValues.y > 0.1f || MoveValues.y < -0.1f)
            _playerAnimator.SetBool("Walking", true);
        else
            _playerAnimator.SetBool("Walking", false);
    }
    
}
