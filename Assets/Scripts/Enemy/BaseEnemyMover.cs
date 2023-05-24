using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseEnemyMover : MonoBehaviour
{
    protected bool IsPhysical;
    protected Rigidbody2D Rb;
    protected virtual void Start()
    {
        if(GetComponent<Rigidbody2D>()!= null)
        {
            Rb = GetComponent<Rigidbody2D>();
            IsPhysical = true;
        }        
        Move();
    }
    protected virtual void Move()
    {
    }
}
