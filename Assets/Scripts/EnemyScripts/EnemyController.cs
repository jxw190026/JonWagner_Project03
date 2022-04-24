using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] GameObject _EnemyWeapon;
    [SerializeField] GameObject _attackTriggerZone;

    Animator _animation;

    PlayerBlockParry _player;

    //animation bools
    
    void Awake()
    {
        _animation = GetComponent<Animator>();
        _player = FindObjectOfType<PlayerBlockParry>();
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
        _animation.SetBool("AttackZone", _attackTriggerZone.GetComponent<TriggerZone>().TriggerStayActivated);
    }

    public void ParryReset()
    {
        //reset the parry bool so the enemy recovers from the parry and attacks again
        _EnemyWeapon.GetComponent<EnemyWeaponController>().parrySuccessful = false;
    }

    public void PlayerParryCheck()
    {
        if (_player.ParryNum < 2)
        {
            _player.ParryNum = 2;
        }
    }


}
