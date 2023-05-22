using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    [SerializeField] private float _cameraSpeed;
    private void Update()
    {
        transform.position = new Vector3(transform.position.x + _cameraSpeed * Time.deltaTime, transform.position.y, transform.position.z);
    }
}
