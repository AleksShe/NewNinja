using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] protected bool Suriken;
    [SerializeField] protected int Health;
    [SerializeField] protected EnemyAnimations EnemyAnimations;

    protected float DieTimer = 0.6f;

    public void GetDamage(int damage)
    {
        if (Suriken)
            return;
        Health -= damage;
        CheckHealth();
    }
    protected virtual void CheckHealth()
    {
        if (Health <= 0)
            StartCoroutine(DestroyObject());
    }
    protected IEnumerator DestroyObject()
    {
        EnemyAnimations.PlayDieAnimation();
        if (GetComponent<Collider2D>() != null)
            GetComponent<Collider2D>().enabled = false;
        if (GetComponent<Rigidbody2D>() != null)
            GetComponent<Rigidbody2D>().isKinematic = true;
        yield return new WaitForSeconds(DieTimer);
        Destroy(gameObject);
    }
    protected void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Weapon weapon))
            GetDamage(weapon.WeaponDamage);
    }
    
}
