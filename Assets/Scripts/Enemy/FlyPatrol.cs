using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyPatrol : MonoBehaviour
{
    [SerializeField] private Transform _point1;
    [SerializeField] private Transform _point2;
    private float _speed = 2f;
    private float _waitTime = 1f;
    private bool _canGo = true;
    private void Start()
    {
        transform.position = new Vector3(_point1.position.x, _point1.position.y, transform.position.z);
    }


    private void Update()
    {
        if (_canGo)
            transform.position = Vector3.MoveTowards(transform.position, _point1.position, _speed * Time.deltaTime);

        if (transform.position == _point1.position)
        {
            var tempPos = _point1;
            _point1 = _point2;
            _point2 = tempPos;
            _canGo = false;
            StartCoroutine(Waiting());
        }

    }
    private IEnumerator Waiting()
    {
        yield return new WaitForSeconds(_waitTime);

        _canGo = true;
    }

}
