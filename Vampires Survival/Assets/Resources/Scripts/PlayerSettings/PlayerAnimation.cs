using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator _animator;
    private PlayerMovement _playerMovement;
    [SerializeField] private ForAttackButton _attackButton;
    [SerializeField] private PlayerHealth _playerDamage;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _playerMovement = GetComponent<PlayerMovement>();
        _playerDamage = GetComponent<PlayerHealth>();
    }
    private void Update()
    {
        AnimationTypeCheck();
    }
    private void AnimationTypeCheck()
    {
        if(_playerMovement._isRunAnimationActive) PlayerRunningAnimation();
        if (!_playerMovement._isRunAnimationActive) PlayerNotRunningAnimation();

        if (_attackButton.isAttackAnimation) PlayerAttackingAnimation();
        if (!_attackButton.isAttackAnimation) PlayerNotAttackingAnimation();

        if (_playerDamage.isHurtAnimationActive) PlayerIsHurtAnimationActive();
        if (!_playerDamage.isHurtAnimationActive) PlayerIsHurtAnimationDisactive();
    }
    private void PlayerRunningAnimation()
    {
        _animator.SetBool("isRun", true);
    }
    private void PlayerNotRunningAnimation()
    {
        _animator.SetBool("isRun", false);
    }  
    private void PlayerAttackingAnimation()
    {
        _animator.SetBool("IsAttack", true);
        _animator.SetBool("isRun", false);
    }
    private void PlayerNotAttackingAnimation()
    {
        _animator.SetBool("IsAttack", false);
    }
    private void PlayerIsHurtAnimationActive()
    {
        _animator.SetBool("isHurt", true);
        _animator.SetBool("isRun", false);
    }
    private void PlayerIsHurtAnimationDisactive()
    {
        _animator.SetBool("isHurt", false);
    }

}
