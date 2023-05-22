using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerAnimations : MonoBehaviour
{
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
    public void PlayIdleAnimation()
    {
        _animator.SetTrigger(IDLE_STATE);
    }
    public void PlayRunAnimation()
    {
        _animator.SetTrigger(RUN_STATE);
    }
    public void PlayJumpAnimation()
    {
        _animator.SetTrigger(JUMP_STATE);
    }
    public void PlayFlyAnimation()
    {
        _animator.SetTrigger(FLY_STATE);
    }
    public void PlayAttackAnimation()
    {
        _animator.SetTrigger(ATTACK_STATE);
    }
    public void PlayBonusAnimation()
    {
        _animator.SetTrigger(BONUS_STATE);
    }
    public void PlaySitAnimation()
    {
        _animator.SetTrigger(SIT_STATE);
    }
    public void PlaySitAttackAnimation()
    {
        _animator.SetTrigger(SIT_ATTACK_STATE);
    }
    public void PlayBonusWeaponAnimation()
    {
        _animator.SetTrigger(BONUS_WEAPON_STATE);
    }
    public void PlaySitBonusWeaponAnimation()
    {
        _animator.SetTrigger(SIT_BONUS_WEAPON_STATE);
    }
    public void PlayHitAnimation()
    {
        _animator.SetTrigger(HIT_STATE);
    }
}
