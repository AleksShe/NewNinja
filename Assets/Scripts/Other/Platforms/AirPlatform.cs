using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirPlatform : BasePlatform
{
    private float _yPoz;

    protected override void Update()
    {
        base.Update();
        transform.position -= new Vector3(Speed * Time.deltaTime, transform.position.y + _yPoz, transform.position.z);
    }
    protected override void ResetPosition()
    {
        if (transform.position.x < Camera.transform.position.x - NewPos)
        {
            _yPoz = Random.Range(1.8f, -1.4f);
            transform.position = new Vector3(Camera.transform.position.x + NewPos, _yPoz, transform.position.z);
           
        }
    }
    
}

