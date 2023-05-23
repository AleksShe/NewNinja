using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Animator))]

public class EnemyAnimations : MonoBehaviour
{
    private Animator _anim;
    private const string DIE_ANIMATION = "Die";
    private void Awake()
    {
        _anim = GetComponent<Animator>();
    }
    public void PlayDieAnimation()
    {
        _anim.SetTrigger(DIE_ANIMATION);
    }
}
