using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum PlayerState
{
    Idle,
    Move,
    Sit,
    Attack,
    BonusAttack,
    TakeDamage,
    Jump,
    SitAttack,
    SitBonusAttack,
}

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float playerSpeed;
    [SerializeField] private float _jumpHeight;
    [SerializeField] private PlayerCollisions _playerCollisions;
    [SerializeField] private WeaponHolder _weapon;
    public PlayerState CurrentState => _currentState;
    private PlayerState _currentState;
    private float _moveSpeed;
    private float _rotateValue = 0.1f;
    private bool _canJump = true;
    private bool _sit = false;

    private Rigidbody2D _rb;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        _playerCollisions.OnGroundTouched += OnAllowJump;
    }
    private void Update()
    {
        MovePlayer();
        Flip();
    }
    public void MovePlayer()
    {
        _rb.velocity = new Vector2(_moveSpeed * playerSpeed, _rb.velocity.y);          
    }
    public void Jump()
    {
        if (!_canJump)
            return;
        _currentState = PlayerState.Jump;
        _rb.AddForce(transform.up * _jumpHeight, ForceMode2D.Impulse);
        _canJump = false;
    }
    public void SetMoveSpeed(float moiveSpeed)
    {
        if (_sit)
            return;
        _moveSpeed = moiveSpeed;
        if (_moveSpeed == 0)
            _currentState = PlayerState.Idle;
        else
            _currentState = PlayerState.Move;
    }
    private void OnAllowJump()
    {
        _canJump = true;
    }
    private void Flip()
    {
        if (_moveSpeed >= _rotateValue)

            transform.rotation = Quaternion.Euler(0, 0, 0);

        else if (_moveSpeed <= -_rotateValue)
            transform.rotation = Quaternion.Euler(0, 180, 0);
    }
    public void UseWeapon()
    {
        if (_sit && _weapon.WeaponState ==WeaponState.Base)
            _currentState = PlayerState.SitAttack;
        else if (_sit && _weapon.WeaponState == WeaponState.Bonus)
            _currentState = PlayerState.SitBonusAttack;
        else if(!_sit && _weapon.WeaponState == WeaponState.Base)
            _currentState = PlayerState.Attack;
        else if (!_sit && _weapon.WeaponState == WeaponState.Bonus)
            _currentState = PlayerState.BonusAttack;
        _weapon.ActivateWeapon();
    }
    public void Sit(bool value)
    {
        _sit = value;
        _playerCollisions.Sit(value);
        if (value && !_weapon.WeaponStatus)
            _currentState = PlayerState.Sit;
        else if(value && _weapon.WeaponStatus)
            _currentState = PlayerState.SitAttack;
    }
}
