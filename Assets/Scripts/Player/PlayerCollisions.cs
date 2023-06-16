using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    [SerializeField] private Collider2D _playerCollider;

    public delegate void OnGround();
    public event OnGround OnGroundTouched;
    public delegate void OnLava();
    public event OnLava OnLavaTouched;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Ground ground))
            OnGroundTouched?.Invoke();
        if (collision.gameObject.TryGetComponent(out Lava lava))
            OnLavaTouched?.Invoke();



    }

    public void Sit(bool value)
    {
        if (value)
            _playerCollider.offset = new Vector2(0.01287758f, -0.01717007f);
        else if (!value)
            _playerCollider.offset = new Vector2(0.01287758f, -0.01717007f);
    }
}
