using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
    Animator _animator;

    //use the parry script to find the bools wether the player is parrying
    PlayerBlockParry _parry;
    //find damage controler script for the hit bool
    DamageController _damage;

    int _horizontal;
    int _vertical;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _horizontal = Animator.StringToHash("Horizontal");
        _vertical = Animator.StringToHash("Vertical");
        _parry = GetComponent<PlayerBlockParry>();
        _damage = GetComponent<DamageController>();
    }


    public void UpdateAnimator(float horizontalMovement, float verticalMovement)
    {
        //animation snapping
        //float snappedHorizontal;
        //float snappedVertical;

        _animator.SetFloat(_horizontal, horizontalMovement, 0.1f, Time.deltaTime);
        _animator.SetFloat(_vertical, verticalMovement, 0.1f, Time.deltaTime);
    }

    private void Update()
    {
        _animator.SetBool("Block", _parry.PlayerBlocking);
        _animator.SetBool("Hit", _damage.PlayerHit);
        _animator.SetFloat("Parry", _parry.ParryNum);
        

    }
}
