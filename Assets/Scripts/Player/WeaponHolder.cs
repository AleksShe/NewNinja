using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum WeaponState
{
    Base,
    Bonus
}
[RequireComponent(typeof(Collider2D))]
public class WeaponHolder : MonoBehaviour
{
    public bool _bonus;
    public bool WeaponStatus => _isEnabled;
    public WeaponState WeaponState => _weaponState;
    [SerializeField] private Weapon _baseWeapon;
    [SerializeField] private Weapon _bonusWeapon;
    private bool _isEnabled;
    private float _delayTimer = 0.5f;
    private WeaponState _weaponState;

    private void Awake()
    {
        if(!_bonus)
        _weaponState= WeaponState.Base;
        else
            _weaponState= WeaponState.Bonus;
    }
    public void ActivateWeapon()
    {
        if (_isEnabled)
            return;
        _isEnabled = true;
        StartCoroutine(ShowWeapon());
    }

    private IEnumerator ShowWeapon()
    {
        if(_weaponState==WeaponState.Base)
            _baseWeapon.gameObject.SetActive(true);
        else if(_weaponState == WeaponState.Bonus)
            _bonusWeapon.gameObject.SetActive(true);
        yield return new WaitForSeconds(_delayTimer);
        if (_weaponState == WeaponState.Base)
            _baseWeapon.gameObject.SetActive(false);
        else if (_weaponState == WeaponState.Bonus)
            _bonusWeapon.gameObject.SetActive(false);
        _isEnabled = false;
    }
    public void ChangeWeaponState(WeaponState newState)
    {
        _weaponState= newState;
    }
    
}
