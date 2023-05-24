using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurikenEnemy : Enemy
{
    [SerializeField] private Suriken _surikenPrefub;
    [SerializeField] private Transform _spawnPos;
    private void Start()
    {
        StartCoroutine(SurikenDelay());
    }
    private IEnumerator SurikenDelay()
    {
        yield return new WaitForSeconds(Random.RandomRange(0.5f, 2));
        EnableSuriken();
        StartCoroutine(SurikenDelay());
    }
    private void EnableSuriken()
    {
        Instantiate(_surikenPrefub,_spawnPos);
    }
}
