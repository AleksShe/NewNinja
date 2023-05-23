using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private EnemyAnimations _enemyAnimations;
    private float _dieTimer = 0.6f;
   

    public void GetDamage(int damage)
    {
        _health -= damage;
        CheckHealth();
    }
    public void CheckHealth()
    {
        if (_health < 0)
            StartCoroutine(DestroyObject());
    }
    private IEnumerator DestroyObject()
    {
        _enemyAnimations.PlayDieAnimation();
        if (GetComponent<Collider2D>() != null)
            GetComponent<Collider2D>().enabled = false;
        if (GetComponent<Rigidbody2D>() != null)
            GetComponent<Rigidbody2D>().isKinematic = true;
        yield return new WaitForSeconds(_dieTimer);
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Weapon weapon))
            GetDamage(weapon.WeaponDamage);
    }
}
