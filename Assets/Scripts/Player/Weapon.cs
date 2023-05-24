using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Collider2D))]
public class Weapon : MonoBehaviour
{
    private Collider2D _collider;
    private bool _isEnabled;
    private float _delayTimer = 0.5f;

    [HideInInspector] public int WeaponDamage { get; private set; } = 1;

    private void Awake()
    {
        _collider= GetComponent<Collider2D>();
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
        _collider.enabled = true;
        yield return new WaitForSeconds(_delayTimer);
        _collider.enabled = false;
        _isEnabled= false;
    }
    
}
