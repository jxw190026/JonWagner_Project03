using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
    Animator _animator;

    int _horizontal;
    int _vertical;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _horizontal = Animator.StringToHash("Horizontal");
        _vertical = Animator.StringToHash("Vertical");
    }


    public void UpdateAnimator(float horizontalMovement, float verticalMovement)
    {
        //animation snapping
        //float snappedHorizontal;
        //float snappedVertical;

        _animator.SetFloat(_horizontal, horizontalMovement, 0.1f, Time.deltaTime);
        _animator.SetFloat(_vertical, verticalMovement, 0.1f, Time.deltaTime);
    }
}
