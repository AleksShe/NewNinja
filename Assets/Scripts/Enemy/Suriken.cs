using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suriken : BaseEnemyMover
{
    private float _speedValue = 8;
    private void Update()
    {
        Move();
    }
    protected override void Move()
    {
        if (IsPhysical)
        {
            Rb.transform.position += new Vector3(0, -_speedValue) * Time.deltaTime;
        }
    }
}
