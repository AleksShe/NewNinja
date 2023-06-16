using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPlatform : BasePlatform
{
    private float _yPoz = 3.13f;
    protected override void Update()
    {
        base.Update();
        transform.position -= new Vector3(Speed * Time.deltaTime, transform.position.y+_yPoz, transform.position.z);
    }
    protected override void ResetPosition()
    {
        if (transform.position.x < Camera.transform.position.x - NewPos)
        {
            transform.position = new Vector3(Camera.transform.position.x + NewPos, _yPoz, transform.position.z);
        }
    }
}
