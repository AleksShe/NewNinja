using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : Enemy
{
    [SerializeField] private SpriteRenderer _sprite;
    protected override void CheckHealth()
    {
        base.CheckHealth();
        StartCoroutine(OnHit());
    }
    private IEnumerator OnHit()
    {
        _sprite.color = new Color(1f, _sprite.color.g - 255f, _sprite.color.b - 0.04f);
        yield return new WaitForSeconds(0.5f);
        _sprite.color = new Color(1f, _sprite.color.g + 255f, _sprite.color.b + 0.04f);
    }

}
