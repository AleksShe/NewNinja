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
        if(Input.GetKeyDown(KeyCode.L))
            _playerController.UseWeapon();
        if (Input.GetKey(KeyCode.S))
            _playerController.Sit(true);
        if (Input.GetKeyUp(KeyCode.S))
            _playerController.Sit(false);

    }
}
