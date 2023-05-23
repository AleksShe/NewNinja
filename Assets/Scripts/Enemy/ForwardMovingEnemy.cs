using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardMovingEnemy : BaseEnemyMover
{
    private float _speedValue = 2;
    private void Update()
    {
        Move();
    }
    protected override void Move()
    {
        if(IsPhysical)
        {
            Rb.transform.position += new Vector3(-_speedValue, 0)* Time.deltaTime;
           
        }
    }
}
