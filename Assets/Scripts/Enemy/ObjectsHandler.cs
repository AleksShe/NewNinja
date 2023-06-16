using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyName
{
    BatEnemy,
    Boss,
    Boss2,
    GroungEnemy,
    SurrikenEnemy,
    WalkingEnemy,
    WhiteEnemy
}

public class ObjectsHandler : MonoBehaviour
{
    [SerializeField] private GameObject _batEnemy;
    [SerializeField] private GameObject _boss;
    [SerializeField] private GameObject _boss2;
    [SerializeField] private GameObject _groundEnemy;
    [SerializeField] private GameObject _walkingEnemy;
    [SerializeField] private GameObject _whiteEnemy;
    [SerializeField] private GameObject _surrikenEnemy;

    public void CreateObject(Transform transform,EnemyName enemyName)
    {
        if(enemyName==EnemyName.BatEnemy)
            Instantiate(_batEnemy, transform);   
        else if(enemyName == EnemyName.Boss) 
            Instantiate(_boss, transform);
        else if (enemyName == EnemyName.Boss2)
            Instantiate(_boss2, transform);
        else if (enemyName == EnemyName.GroungEnemy)
            Instantiate(_groundEnemy, transform);
        else if (enemyName == EnemyName.SurrikenEnemy)
            Instantiate(_surrikenEnemy, transform);
        else if (enemyName == EnemyName.WalkingEnemy)
            Instantiate(_walkingEnemy, transform);
        else if (enemyName == EnemyName.WhiteEnemy)
            Instantiate(_whiteEnemy, transform);
    }




}
