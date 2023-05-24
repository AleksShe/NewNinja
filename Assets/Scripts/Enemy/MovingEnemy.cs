using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum MovingSide
{
    X,
    Y,
    REVERT_X,
    REVERT_Y
}

public class MovingEnemy : BaseEnemyMover
{
    [SerializeField] private MovingSide _movingSide;
    private float _speedValue = 2;
    private Vector3 _moveVector;

    protected override void Start()
    {
        base.Start();
        switch (_movingSide)
        {
            case MovingSide.X:
                _moveVector = new Vector3(_speedValue, 0);
                break;
            case MovingSide.REVERT_X:
                _moveVector = new Vector3(-_speedValue, 0);
                break;
            case MovingSide.Y:
                _moveVector = new Vector3(0, _speedValue);
                break;
            case MovingSide.REVERT_Y:
                _moveVector = new Vector3(0, -_speedValue);
                break;
            default:
                _moveVector = new Vector3(_speedValue, 0);
                break;
        }
    }
    private void Update()
    {
        Move();
    }
    protected override void Move()
    {
        if (IsPhysical)
        {
            Rb.transform.position += _moveVector * Time.deltaTime;
        }
    }
}
