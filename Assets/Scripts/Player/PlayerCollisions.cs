using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    [SerializeField] private Collider2D _playerCollider;

    public delegate void OnGround();
    public event OnGround OnGroundTouched;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Ground ground))
            OnGroundTouched?.Invoke();
    }
    public void Sit(bool value)
    {
        if(value)
            _playerCollider.offset = new Vector2(0.01287758f, -0.01717007f);
        else if (!value)
            _playerCollider.offset = new Vector2(0.01287758f, -0.01717007f);
    }
}
