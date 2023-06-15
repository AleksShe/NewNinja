using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerAnimations : MonoBehaviour
{
    [SerializeField] private PlayerController _playerController;
    private Animator _animator;
    private const string IDLE_STATE = "Idle";
    private const string RUN_STATE = "Run";
    private const string JUMP_STATE = "Jump";
    private const string FLY_STATE = "Fly";
    private const string ATTACK_STATE = "Attack";
    private const string BONUS_STATE = "Bonus";
    private const string SIT_STATE = "Sit";
    private const string SIT_ATTACK_STATE = "SitAttack";
    private const string BONUS_WEAPON_STATE = "BonusWeapon";
    private const string SIT_BONUS_WEAPON_STATE = "SitBonusWeapon";
    private const string HIT_STATE = "Hit";

    private void Awake()
    {
        _animator= GetComponent<Animator>();
    }
    private void Update()
    {
        if (_playerController.CurrentState == PlayerState.Idle)
            PlayIdleAnimation();
        else if (_playerController.CurrentState == PlayerState.Move)
            PlayMoveAnimation();
        else if (_playerController.CurrentState == PlayerState.Sit)
            PlaySitAnimation();
        else if (_playerController.CurrentState == PlayerState.Attack)
            PlayAttackAnimation();
        else if (_playerController.CurrentState == PlayerState.TakeDamage)
            PlayTakeDamageAnimation();
        else if (_playerController.CurrentState == PlayerState.Jump)
            PlayJumpAnimation();
        else if (_playerController.CurrentState == PlayerState.SitAttack)
            PlaySitAttackAnimation();
        else if (_playerController.CurrentState == PlayerState.BonusAttack)
            PlayBonusAnimation();
        else if (_playerController.CurrentState == PlayerState.SitBonusAttack)
            PlaySitBonusWeaponAnimation();
    }
    private void PlayIdleAnimation()
    {
        _animator.SetTrigger(IDLE_STATE);
    }
    private void PlayMoveAnimation()
    {
        _animator.SetTrigger(RUN_STATE);
    }
    private void PlayJumpAnimation()
    {
        _animator.SetTrigger(JUMP_STATE);
    }
    private void PlayFlyAnimation()
    {
        _animator.SetTrigger(FLY_STATE);
    }
    private void PlayAttackAnimation()
    {
        _animator.SetTrigger(ATTACK_STATE);
    }
    private void PlayBonusAnimation()
    {
        _animator.SetTrigger(BONUS_STATE);
    }
    private void PlaySitAnimation()
    {
        _animator.SetTrigger(SIT_STATE);
    }
    private void PlaySitAttackAnimation()
    {
        _animator.SetTrigger(SIT_ATTACK_STATE);
    }
    private void PlayBonusWeaponAnimation()
    {
        _animator.SetTrigger(BONUS_WEAPON_STATE);
    }
    private void PlaySitBonusWeaponAnimation()
    {
        _animator.SetTrigger(SIT_BONUS_WEAPON_STATE);
    }
    private void PlayTakeDamageAnimation()
    {
        _animator.SetTrigger(HIT_STATE);
    }
}
