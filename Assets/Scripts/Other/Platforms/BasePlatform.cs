using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlatform : MonoBehaviour
{
    [SerializeField] protected float NewPos = 11f;
    [SerializeField] protected float Speed = 1f;
    protected Camera Camera;

    protected void Awake()
    {
        Camera = Camera.main;
    }
    protected virtual void Update()
    {
        ResetPosition();
    }
    protected virtual void ResetPosition()
    {
    }
}
