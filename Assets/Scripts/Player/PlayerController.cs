using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float playerSpeed;
    [SerializeField] private float _jumpHeight;
    [SerializeField] private PlayerCollisions _playerCollisions;
    [SerializeField] private PlayerAnimations _playerAnimations;
    [SerializeField] private Weapon _weapon;
    private float _moveSpeed;
    private float _rotateValue = 0.1f;
    private bool _canJump = true;

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
        _playerAnimations.PlayJumpAnimation();
        _rb.AddForce(transform.up * _jumpHeight, ForceMode2D.Impulse);
        _canJump = false;
    }
    public void SetMoveSpeed(float moiveSpeed)
    {
        _moveSpeed = moiveSpeed;
        if(_moveSpeed==0)
            _playerAnimations.PlayIdleAnimation();
        else 
            _playerAnimations.PlayRunAnimation();
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
        _weapon.ActivateWeapon();
        _playerAnimations.PlayAttackAnimation();
    }
}
