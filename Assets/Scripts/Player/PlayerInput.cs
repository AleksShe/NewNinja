using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private PlayerController _playerController;
    private void Update()
    {
        _playerController.SetMoveSpeed(Input.GetAxis("Horizontal"));
        if (Input.GetKeyDown(KeyCode.Space))
            _playerController.Jump();
    }
}
