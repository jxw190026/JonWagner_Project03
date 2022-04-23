using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] GameObject _EnemyWeapon;
    [SerializeField] GameObject _attackTriggerZone;

    Animator _animation;

    //animation bools
    
    void Awake()
    {
        _animation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        SuccessfulParry();
        AttackTriggerZone();
    }

    public void WeaponTagChange(string tagName)
    {
        _EnemyWeapon.transform.gameObject.tag = tagName;
    }

    private void SuccessfulParry()
    {
        _animation.SetBool("Parried", _EnemyWeapon.GetComponent<EnemyWeaponController>().parrySuccessful);
    }

    private void AttackTriggerZone()
    {
        _animation.SetBool("AttackZone", _attackTriggerZone.GetComponent<TriggerZone>().TriggerActivated);
    }

    public void ParryReset()
    {
        //reset the parry bool so the enemy recovers from the parry and attacks again
        _EnemyWeapon.GetComponent<EnemyWeaponController>().parrySuccessful = false;
    }


}
