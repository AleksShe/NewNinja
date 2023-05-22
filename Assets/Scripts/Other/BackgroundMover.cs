using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BackgroundMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _camPos;

    private float _startValue = 19.5f;
    private float _resetValue = 18;

    private void Update()
    {
        transform.position = new Vector2(transform.position.x - _speed * Time.deltaTime, transform.position.y);
        if (transform.position.x < _camPos.position.x -_resetValue)
        {
            Vector2 resetPosition = new Vector2(_camPos.position.x + _startValue, transform.position.y);
            transform.position = resetPosition;
        }
    }
}
